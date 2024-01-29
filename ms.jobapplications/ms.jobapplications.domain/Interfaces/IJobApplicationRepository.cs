using ms.jobapplications.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobapplications.domain.Interfaces
{
    public interface IJobApplicationRepository
    {
        Task<List<JobApplication>> GetAllJobApplications();

        Task<int> CreateJobApplication(JobApplication jobApplication);
    }
}