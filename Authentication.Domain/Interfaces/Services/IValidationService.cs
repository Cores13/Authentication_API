namespace Authentication.Domain.Interfaces.Services
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IValidationService
    {
        Task<bool> IsEmailUnique(string email);

        bool IsUserEmailUnique(string email, long? userId = null);
    }
}
