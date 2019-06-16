using Coravel.Pro.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CoravelProSample
{
    public class SampleDbContext : DbContext, ICoravelProDbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        { }
        
        public DbSet<CoravelJobHistory> Coravel_JobHistory { get; set; }
        public DbSet<CoravelScheduledJob> Coravel_ScheduledJobs { get; set; }
        public DbSet<CoravelScheduledJobHistory> Coravel_ScheduledJobHistory { get; set; }
    }
}