using MediatR;
using ms.jobseekers.application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobseekers.application.Queries
{
    public record GetAllJobSeekersQuery() : IRequest<IEnumerable<JobSeekerResponse>>;
}
