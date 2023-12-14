using AutoMapper;
using ms.web.application.Responses;
using ms.web.domain.Entities;

namespace ms.web.application.Mapper
{
    public class AdminDashboardProfile : Profile
    {
        public AdminDashboardProfile()
        {
            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
