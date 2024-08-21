using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Students> students { get; set; }
        public SchoolContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
