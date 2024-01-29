using Microsoft.EntityFrameworkCore;
using ms.jobapplications.domain.Entities;

namespace ms.jobapplications.infrastructure.Data
{
    public class JobApplicationContext : DbContext
    {
        public JobApplicationContext(DbContextOptions<JobApplicationContext> options) : base(options)
        {
        }

        public DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobApplication>()
                        .HasData(
                            new JobApplication() { 
                                Id = 1,
                                Position = "NET Dev", 
                                Organization = "Hplus Company", 
                                City = "Lima", 
                                LinkToJobOffer="https://www.jobs.com/243", 
                                Salary="S/. 6000", 
                                ContactDetails="John Doe", 
                                Notes =  "Primera Entrevista" 
                            }
                        );
        }
    }
}