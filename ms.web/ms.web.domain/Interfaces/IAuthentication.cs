using ms.web.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.domain.Interfaces
{
    public interface IAuthentication
    {
        Task<User> Login(string user, string password);
    }
}
