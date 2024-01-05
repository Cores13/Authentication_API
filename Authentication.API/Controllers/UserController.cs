using Authentication.Application.Password.ForgotPasswordRequest;
using Authentication.Application.Password.ForgotPasswordReset;
using Authentication.Application.Password.ForgotPasswordVerifyCode;
using Authentication.Application.Users.Commands.Create;
using Authentication.Application.Users.Commands.Delete;
using Authentication.Application.Users.Commands.Login;
using Authentication.Application.Users.Commands.RenewToken;
using Authentication.Application.Users.Commands.ResendVerificationEmail;
using Authentication.Application.Users.Commands.Update;
using Authentication.Application.Users.Commands.UpdateMe;
using Authentication.Application.Users.Commands.VerifyEmail;
using Authentication.Application.Users.Queries.GetOne;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Paging;
using Authentication.Domain.DTOs.Request;
using Authentication.Domain.DTOs.Requests;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.API.Controllers
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
            }
        }

        [HttpDelete("{id}")]
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
                return HandleFailure(Result.Failure(new Error("BadRequest", ex.Message)));
            }
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> ResendVerificationEmail(int id, CancellationToken cancellationToken)
        {
            try
            {
                var command = new ResendVerificationEmailCommand(id);

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
    }
}
