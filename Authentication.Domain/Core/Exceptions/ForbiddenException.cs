using Authentication.Domain.Enums;

namespace Authentication.Domain.Core.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException(ErrorCode errorCode = ErrorCode.ActionForbidden) : base(errorCode.ToString())
        {
        }
    }
}
