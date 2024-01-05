using Authentication.Infrastructure.Options.Authentication;
using Microsoft.Extensions.Options;

namespace Authentication.API.OptionsSetup
{
    public class JwtOptionsSetup : IConfigureOptions<JwtOptions>
    {
        private const string SectionName = "Jwt";
        public readonly IConfiguration _configuration;
        public JwtOptionsSetup(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public void Configure(JwtOptions options)
        {
            _configuration.GetSection(SectionName).Bind(options);
        }
    }
}
