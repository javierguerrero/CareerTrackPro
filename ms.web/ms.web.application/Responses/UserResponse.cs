﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.application.Responses
{
    public class UserResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string Expiration { get; set; }
    }
}
