﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.application.HttpCommunications.Responses
{
    public class AuthenticationApiCommunicationResponse
    {
        public string Token { get; set; }
        public string Expiration { get; set; }
    }
}
