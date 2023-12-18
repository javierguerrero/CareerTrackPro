using AutoMapper;
using MediatR;
using ms.jobseekers.application.Responses;
using ms.jobseekers.domain.Interfaces;

namespace ms.jobseekers.application.Queries.Handlers
{
    public class GetAllJobSeekersQueryHandler : IRequestHandler<GetAllJobSeekersQuery, IEnumerable<JobSeekerResponse>>
    {
        private readonly IJobSeekertRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetAllJobSeekersQueryHandler(IJobSeekertRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobSeekerResponse>> Handle(GetAllJobSeekersQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllJobSeekers();
            return _mapper.Map<IEnumerable<JobSeekerResponse>>(students);
        }
    }
}