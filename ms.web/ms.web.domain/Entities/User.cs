using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.domain.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Expiration { get; set; }
    }
}
