using Digimash.Domain.Enums;

namespace Digimash.Domain.Core.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException(ErrorCode errorCode = ErrorCode.ActionForbidden) : base(errorCode.ToString())
        {
        }
    }
}
