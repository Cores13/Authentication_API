using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Application.Users.Commands.Login
{
    public record LoginRequest(string email, string password);
}
