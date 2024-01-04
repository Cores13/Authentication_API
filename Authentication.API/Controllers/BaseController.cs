﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Digimash.Domain.Enums;
using MediatR;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Interfaces.Primitives;
using System.Xml.Linq;

namespace Digimash.API.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ISender Sender;


        protected BaseController(ISender sender)
        {
            Sender = sender;
        }

        [NonAction]
        protected IActionResult HandleFailure(Result result) =>
            result switch
            {
                { IsSuccess: true } => throw new InvalidOperationException(),
                IValidationResult validationResult =>
                    BadRequest(
                        CreateProblemDetails(
                            "Validation Error", StatusCodes.Status400BadRequest,
                            result.Error,
                            validationResult.Errors)),
                _ =>
                BadRequest(
                        CreateProblemDetails(
                            "Bad Request", 
                            StatusCodes.Status400BadRequest,
                            result.Error,
                            [result.Error])),
            };

        [NonAction]
        private static ProblemDetails CreateProblemDetails(
            string title,
            int status,
            Error error,
            Error[]? errors = null) =>
            new ProblemDetails()
            {
                Title = title,
                Type = error.Code,
                Detail = error.Message,
                Status = status,
                Extensions = { { nameof(errors), errors } }
            };

        [NonAction]
        public virtual int GetCurrentUserId()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var currentUserId = Int32.Parse(claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            return currentUserId;
        }

        [NonAction]
        public virtual UserRoleEnum? GetCurrentUserRole()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var role = claimsIdentity.FindFirst(ClaimTypes.Role)?.Value;
            UserRoleEnum? currentUserRole = null;

            if (role != null)
            {
                currentUserRole = Enum.TryParse<UserRoleEnum>(role, out var outRole) ? outRole : (UserRoleEnum?)null;
            }

            return currentUserRole;
        }

        [NonAction]
        public virtual string GetDeviceId()
        {
            var deviceId = HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "x-deviceid");
            return deviceId.Value;
        }
    }
}