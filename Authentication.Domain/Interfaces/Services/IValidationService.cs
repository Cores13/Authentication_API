namespace Authentication.Domain.Interfaces.Services
{
    public interface IValidationService
    {
        bool IsUsernameUnique(string username, int? userId = null);

        bool IsUserEmailUnique(string email, int? userId = null);

        bool ValidatePhoneNumber(string phoneNumber, string phoneRegion);

        bool UniquePhoneNumber(string phoneNumber, int? userId = null);
    }
}
