using Digimash.Domain.Core.Primitives;

namespace Digimash.Domain.Interfaces.Primitives
{
    public interface IValidationResult
    {
        public static readonly Error ValidationError = new(
            "ValidationError",
            "A validation problem occurred.");

        Error[] Errors { get; }
    }
}
