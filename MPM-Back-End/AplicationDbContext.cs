using MPM_Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace MPM_Back_End
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<UserData> Users { get; set; } = null!;
        public DbSet<ProjectData> Projects { get; set; } = null!;
        public DbSet<ActivityData> Activities { get; set; } = null!;
        public DbSet<ProjectsHasUser> ProjectsHasUsers { get; set; } = null!;

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
