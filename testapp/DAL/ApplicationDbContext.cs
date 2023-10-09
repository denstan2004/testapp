using Microsoft.EntityFrameworkCore;
using testapp.Enteties;

namespace testapp.DAL
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        public DbSet<User> User { get; set; }
       
    }
}
