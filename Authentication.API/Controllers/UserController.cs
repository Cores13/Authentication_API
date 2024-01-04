using Digimash.Application.Password.ForgotPasswordRequest;
using Digimash.Application.Password.ForgotPasswordReset;
using Digimash.Application.Password.ForgotPasswordVerifyCode;
using Digimash.Application.Users.Commands.Create;
using Digimash.Application.Users.Commands.Delete;
using Digimash.Application.Users.Commands.Login;
using Digimash.Application.Users.Commands.RenewToken;
using Digimash.Application.Users.Commands.Update;
using Digimash.Application.Users.Commands.UpdateMe;
using Digimash.Application.Users.Commands.VerifyEmail;
using Digimash.Application.Users.Queries.GetOne;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.DTOs.Paging;
using Digimash.Domain.DTOs.Request;
using Digimash.Domain.DTOs.Requests;
using Digimash.Domain.Templates;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Digimash.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : BaseController
    {
        private readonly IValidator<CreateUserCommand> _validator;

        public UserController(ISender sender, IValidator<CreateUserCommand> validator) :base(sender)
        {
            _validator = validator;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Me(CancellationToken cancellationToken)
        {
            try
            {
                var currentUserId = GetCurrentUserId();
                var command = new GetOneUserQuery(currentUserId);

                var result = await Sender.Send(command);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "SuperAdministrator")]
        public async Task<IActionResult> GetOne(int id, CancellationToken cancellationToken)
        {
            try
            {
                var command = new GetOneUserQuery(id);
                var result = await Sender.Send(command, cancellationToken);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet]
        [Authorize(Roles = "SuperAdministrator")]
        public async Task<IActionResult> GetAll([FromQuery] PagedRequest<string> pagedQuery, CancellationToken cancellationToken)
        {
            try
            {
                var command = new GetAllUsersQuery(pagedQuery);
                var result = await Sender.Send(command, cancellationToken);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        [Authorize(Roles="SuperAdministrator")]
        public async Task<IActionResult> Create(UserRequestDto user, CancellationToken cancellationToken)
        {
            try
            {
                var command = new CreateUserCommand(
                    user.Name,
                    user.Email,
                    user.Password,
                    (int)user.Role,
                    null);

                var result = await Sender.Send(command);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequestDto user, CancellationToken cancellationToken)
        {
            try
            {
                var command = new LoginCommand(
                    user.Email,
                    user.Password);

                var tokenResult = await Sender.Send(command, cancellationToken);

                if(tokenResult.IsFailure)
                {
                    return HandleFailure(tokenResult);
                }

                return Ok(tokenResult.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RenewRefreshToken(TokenRequestDto tokenApiDto, CancellationToken cancellationToken)
        {
            try
            {
                if (tokenApiDto is null)
                {
                    return BadRequest("Invalid request");
                }

                var command = new RenewTokenCommand(
                    tokenApiDto.AccessToken,
                    tokenApiDto.RefreshToken);

                var tokenResult = await Sender.Send(command, cancellationToken);

                if (tokenResult.IsFailure)
                {
                    return HandleFailure(tokenResult);
                }

                return Ok(tokenResult.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateMe(UserRequestDto user, CancellationToken cancellationToken)
        {
            try
            {
                var currentUserId = GetCurrentUserId();
                var command = new UpdateMeCommand(
                    currentUserId,
                    user.Name,
                    user.Email,
                    user.Password);

                var result = await Sender.Send(command, cancellationToken);
                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message});
            }
        }

        [HttpPut]
        [Authorize(Roles = "SuperAdministrator")]
        public async Task<IActionResult> Update(UserRequestDto user, CancellationToken cancellationToken)
        {
            try
            {
                var command = new UpdateUserCommand(
                    user.Id,
                    user.Name,
                    user.Email,
                    user.Password,
                    user.Role);

                var result = await Sender.Send(command, cancellationToken);
                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete]
        [Authorize(Roles = "SuperAdministrator")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            try
            {
                var command = new DeleteUserCommand(id);

                var result = await Sender.Send(command, cancellationToken);
                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ForgotPasswordRequest(ForgotPasswordRequestDto request, CancellationToken cancellationToken)
        {
            try
            {
                if (request is null)
                {
                    return BadRequest("Invalid request");
                }

                var command = new ForgotPasswordRequestCommand(request.Email);

                var result = await Sender.Send(command, cancellationToken);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
            }
        }
        
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ForgotPasswordVerifyCode(ForgotPasswordVerifyCodeDto request, CancellationToken cancellationToken)
        {
            try
            {
                if (request is null)
                {
                    return BadRequest("Invalid request");
                }

                var command = new ForgotPasswordVerifyCodeCommand(request.Email, request.Code);

                var result = await Sender.Send(command, cancellationToken);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
                //return BadRequest(new { message = ex.Message });
            }
        }
        
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ForgotPasswordReset(ForgotPasswordResetDto request, CancellationToken cancellationToken)
        {
            try
            {
                if (request is null)
                {
                    return BadRequest("Invalid request");
                }

                var command = new ForgotPasswordResetCommand(request.Email, request.Password, request.Code);

                var result = await Sender.Send(command, cancellationToken);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
            }
        }

        [HttpPost("{id}/{code}")]
        public async Task<IActionResult> VerifyEmail(int id, string code, CancellationToken cancellationToken)
        {
            try
            {
                if (code is null)
                {
                    return BadRequest("Invalid request");
                }

                var command = new VerifyEmailCommand(id, code);

                var result = await Sender.Send(command, cancellationToken);

                if (result.IsFailure)
                {
                    return HandleFailure(result);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                //return BadRequest(new { message = ex.Message });
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
            }
        }
    }
}
