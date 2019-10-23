using DW.API.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DW.API.Persistence
{
    public class EnterpriseContext : IdentityDbContext<ApplicationUser>
    {
        public EnterpriseContext(DbContextOptions<EnterpriseContext> options)
           : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
