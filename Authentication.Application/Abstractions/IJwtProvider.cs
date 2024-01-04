using Digimash.Domain.Entities;

namespace Digimash.Application.Abstractions
{
    public interface IJwtProvider
    {
        string Generate(User user);
    }
}
