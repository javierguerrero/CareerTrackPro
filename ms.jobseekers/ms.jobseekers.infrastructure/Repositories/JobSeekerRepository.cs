using Microsoft.EntityFrameworkCore;
using ms.jobseekers.domain.Entities;
using ms.jobseekers.domain.Interfaces;
using ms.jobseekers.infrastructure.Data;

namespace ms.jobseekers.infrastructure.Repositories
{
    public class JobSeekerRepository : IJobSeekertRepository
    {
        private readonly JobSeekerContext _context;

        public JobSeekerRepository(JobSeekerContext context)
        {
            _context = context;
        }

        public async Task<List<JobSeeker>> GetAllJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }

        public async Task<string> CreateJobSeeker(JobSeeker jobseeker)
        {
            await _context.AddAsync(jobseeker);
            await _context.SaveChangesAsync();
            return jobseeker.UserName;
        }
    }
}