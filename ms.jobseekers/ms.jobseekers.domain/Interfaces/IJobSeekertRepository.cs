using ms.jobseekers.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobseekers.domain.Interfaces
{
    public interface IJobSeekertRepository
    {
        Task<List<JobSeeker>> GetAllJobSeekers();
        Task<string> CreateJobSeeker(JobSeeker student);
    }
}
