using Digimash.Domain.Enums;

namespace Digimash.Domain.Core.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(ErrorCode errorCode) : base(errorCode.ToString())
        {
        }
    }
}
