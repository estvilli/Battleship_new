using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Person> People
 
         public AppDbContext(DbContextOptions options) : base(options)
         {
             
         }
    }
}