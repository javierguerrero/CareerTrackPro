using Microsoft.EntityFrameworkCore;
using ms.jobseekers.domain.Entities;

namespace ms.jobseekers.infrastructure.Data
{
    public class JobSeekerContext : DbContext
    {
        public JobSeekerContext(DbContextOptions<JobSeekerContext> options) : base(options)
        {
        }

        public DbSet<JobSeeker> JobSeekers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobSeeker>()
                .HasData(
                    new JobSeeker() { Id = 1, UserName = "mcampovero", FirstName = "Maribel", LastName = "Campovero" },
                    new JobSeeker() { Id = 2, UserName = "jdoe", FirstName = "John", LastName = "Doe" }
                );
        }
    }
}