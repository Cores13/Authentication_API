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
        public static class User
        {
            /// <summary>
            /// Email or password is not valid error.
            /// </summary>
            public static Error InvalidCredentials => new Error("User.InvalidCredentials", "Email or password is not valid.");

            /// <summary>
            /// User does not exist error.
            /// </summary>
            public static Error DoesNotExist => new Error("User.DoesNotExist", "User does not exist.");

            /// <summary>
            /// Specified role does not exist error.
            /// </summary>
            public static Error InvalidRole => new Error("User.InvalidRole", "Specified role does not exist.");

            /// <summary>
            /// Invalid request error.
            /// </summary>
            public static Error InvalidRequest => new Error("User.InvalidRequest", "Invalid request.");

            /// <summary>
            /// User email is not verified error.
            /// </summary>
            public static Error UserNotVerified => new Error("User.UserNotVerified", "User email is not verified.");
        }
    }
}
