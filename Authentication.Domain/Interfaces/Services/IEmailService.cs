using Authentication.Domain.DTOs.Email;

namespace Authentication.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(MailDataDto request, CancellationToken ct);

        Task<bool> SendVerificationCodeEmailAsync(List<string> to, string userName, string code);

        Task<bool> SendEmailVerificationCodeEmail(List<string> to, string userName, string code);
    }
}
