using ms.web.application.HttpCommunications.Requests;
using ms.web.application.HttpCommunications.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.application.HttpCommunications
{
    
    public interface IAuthtenticationApiCommunication
    {
        [Post("/api/Authenticate/login")]
        Task<AuthenticationApiCommunicationResponse> Login([Body] AuthenticationApiCommunicationRequest request);
    }
}
