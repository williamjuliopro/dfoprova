using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApi.Entities
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        { 
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public virtual DbSet<User> User { get; set; }


        

    }
}
