using Authentication.Domain.Entities;

namespace Authentication.Application.Abstractions
{
    public interface IJwtProvider
    {
        string Generate(User user);
    }
}
