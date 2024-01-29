using MediatR;
using ms.jobapplications.application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobapplications.application.Queries
{
    public record GetAllJobApplicationsQuery() : IRequest<IEnumerable<JobApplicationResponse>>;

}
