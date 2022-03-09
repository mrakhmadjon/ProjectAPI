using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI.Data.Contexts
{
    public class UniverDbContext : DbContext
    {
        public UniverDbContext(DbContextOptions<UniverDbContext> options)
            : base(options) 
        {

        }
       public virtual DbSet<UserModel> Users { get; set; }
    }
}
