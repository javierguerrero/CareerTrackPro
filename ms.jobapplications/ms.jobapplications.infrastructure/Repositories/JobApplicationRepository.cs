using Microsoft.EntityFrameworkCore;
using ms.jobapplications.domain.Entities;
using ms.jobapplications.domain.Interfaces;
using ms.jobapplications.infrastructure.Data;

namespace ms.jobapplications.infrastructure.Repositories
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly JobApplicationContext _context;

        public JobApplicationRepository(JobApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<JobApplication>> GetAllJobApplications()
        {
            return await _context.JobApplications.ToListAsync();
        }

        public async Task<int> CreateJobApplication(JobApplication jobApplication)
        {
            await _context.AddAsync(jobApplication);
            await _context.SaveChangesAsync();
            return jobApplication.Id;
        }
    }
}