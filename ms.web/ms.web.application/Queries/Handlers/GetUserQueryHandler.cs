using AutoMapper;
using MediatR;
using ms.web.application.HttpCommunications;
using ms.web.application.HttpCommunications.Requests;
using ms.web.application.Responses;
using ms.web.domain.Entities;

namespace ms.web.application.Queries.Handlers
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserResponse>
    {
        private readonly IAuthtenticationApiCommunication _authtenticationApiCommunication;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IMapper mapper,
                                   IAuthtenticationApiCommunication authtenticationApiCommunication)
        {
            _mapper = mapper;
            _authtenticationApiCommunication = authtenticationApiCommunication;
        }

        public async Task<UserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var loginResponse = await _authtenticationApiCommunication.Login(new AuthenticationApiCommunicationRequest { Username = request.username, Password = request.password });
            var user = new UserResponse
            {
                Username = request.username,
                Token = loginResponse.Token,
                Expiration = loginResponse.Expiration,
            };

            return user;
        }
    }
}