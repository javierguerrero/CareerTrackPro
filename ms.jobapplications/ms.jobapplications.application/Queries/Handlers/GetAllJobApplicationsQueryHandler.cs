using MediatR;
using ms.jobapplications.application.Responses;
using ms.jobapplications.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobapplications.application.Queries.Handlers
{
    public class GetAllJobApplicationsQueryHandler : IRequestHandler<GetAllJobApplicationsQuery, IEnumerable<JobApplicationResponse>>
    {
        private readonly IJobApplicationRepository _jobApplicationRepository;
        //private readonly IMapper _mapper;

        public GetAllJobApplicationsQueryHandler(IJobApplicationRepository jobApplicationRepository)
        {
            _jobApplicationRepository = jobApplicationRepository;
        }

        public async Task<IEnumerable<JobApplicationResponse>> Handle(GetAllJobApplicationsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
