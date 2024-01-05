namespace Authentication.Domain.DTOs.Requests
{
    public class TokenRequestDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
 