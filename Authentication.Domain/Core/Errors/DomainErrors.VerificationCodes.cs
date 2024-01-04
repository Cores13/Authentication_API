using Digimash.Domain.Core.Primitives;

namespace Digimash.Domain.Core.Errors
{
    /// <summary>
    /// Contains the domain errors.
    /// </summary>
    public static partial class DomainErrors
    {
        /// <summary>
        /// Contains the model name errors.
        /// </summary>
        public static class VerificationCodes
        {
            /// <summary>
            /// Email or password is not valid error.
            /// </summary>
            public static Error InvalidOrExpiredCode => new Error("User.InvalidOrExpiredCode", "Verification code is invalid or expired.");
        }
    }
}
