using Digimash.Domain.Enums;

namespace Digimash.Domain.Core.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(ErrorCode errorCode) : base(errorCode.ToString())
        {
        }
    }
}
