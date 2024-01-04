using Digimash.Infrastructure.Options.Email;
using Microsoft.Extensions.Options;

namespace Digimash.API.OptionsSetup
{
    public class EmailOptionsSetup : IConfigureOptions<EmailOptions>
    {
        private const string SectionName = "MailSettings";
        public readonly IConfiguration _configuration;
        public EmailOptionsSetup(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public void Configure(EmailOptions options)
        {
            _configuration.GetSection(SectionName).Bind(options);
        }
    }
}
