using MediatR;
using ms.web.application.Responses;

namespace ms.web.application.Queries
{
    public record GetUserQuery(string username, string password) : IRequest<UserResponse>;
}
