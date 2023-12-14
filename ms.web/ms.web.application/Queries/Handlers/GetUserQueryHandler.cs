using AutoMapper;
using MediatR;
using ms.web.application.Responses;
using ms.web.domain.Interfaces;

namespace ms.web.application.Queries.Handlers
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserResponse>
    {
        private readonly IAuthentication _authentication;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IAuthentication authentication, IMapper mapper)
        {
            _authentication = authentication;
            _mapper = mapper;
        }

        public async Task<UserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _authentication.Login(request.username, request.password);
            return _mapper.Map<UserResponse>(user);
        }
    }
}