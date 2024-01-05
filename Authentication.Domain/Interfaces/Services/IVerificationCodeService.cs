using Authentication.Domain.Enums;

namespace Authentication.Domain.Interfaces.Services
{
    public interface IVerificationCodeService
    {
        Task<string> GetCodeAsync(int userId, VerificationCodeType type, CancellationToken cancellationToken);
        Task<bool> VerifyCodeAsync(int userId, string code, VerificationCodeType type, CancellationToken cancellationToken, bool deleteIfValid = false);
        Task<string> CreateCodeAsync(int userId, VerificationCodeType type, CancellationToken cancellationToken);
    }
}
