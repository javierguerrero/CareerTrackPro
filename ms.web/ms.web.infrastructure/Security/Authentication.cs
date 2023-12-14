using ms.web.domain.Entities;
using ms.web.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.infrastructure.Security
{
    public class Authentication : IAuthentication
    {
        public Task<User> Login(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
