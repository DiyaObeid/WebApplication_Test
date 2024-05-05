using Microsoft.EntityFrameworkCore;
using WebApplication_Test.Models;

namespace WebApplication_Test.DBconction
{

    public class ApplicationDBContext : DbContext
    {
        //Tables
        public DbSet<Moves> Moves { get; set; }
        
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}