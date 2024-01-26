using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Interfaces.Services;
using PhoneNumbers;

namespace Authentication.Infrastructure.Services
{
    public class ValidationService : IValidationService
    {
        private readonly IUserRepository _userRepository;

        public ValidationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsUsernameUnique(string username, int? userId = null)
        {
            try
            {
                var user = _userRepository.IsUsernameUnique(username, userId);
                return user;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsUserEmailUnique(string email, int? userId = null)
        {
            try
            {
                var user = _userRepository.IsEmailUnique(email, userId);
                return user;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ValidatePhoneNumber(string phoneNumber, string phoneRegion)
        {
            try
            {
                var phoneNumberUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();
                var pn = phoneNumberUtil.Parse(phoneNumber, phoneRegion);
                var isValid = phoneNumberUtil.IsValidNumber(pn);

                return isValid;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UniquePhoneNumber(string phoneNumber, int? userId = null)
        {
            try
            {
                var phoneNumberUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();
                var pn = phoneNumberUtil.Parse(phoneNumber, "BA");
                var formattedPhoneNumber = phoneNumberUtil.Format(pn, PhoneNumberFormat.E164);

                var userExists = _userRepository.IsPhoneNumberUnique(formattedPhoneNumber, userId);
                return userExists;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
