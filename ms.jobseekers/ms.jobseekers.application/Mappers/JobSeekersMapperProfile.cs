using AutoMapper;
using ms.rabbitmq.Events;
using ms.jobseekers.application.Commands;
using ms.jobseekers.application.Responses;
using ms.jobseekers.domain.Entities;

namespace ms.jobseekers.application.Mappers
{
    public class JobSeekersMapperProfile : Profile
    {
        public JobSeekersMapperProfile()
        {
            CreateMap<JobSeeker, JobSeekerResponse>().ReverseMap();
            CreateMap<CreateJobSeekerCommand, JobSeekerCreatedEvent>().ReverseMap();
        }
    }
}