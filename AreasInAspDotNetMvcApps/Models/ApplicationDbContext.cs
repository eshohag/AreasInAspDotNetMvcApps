using AreasInAspDotNetMvcApps.Areas.Blogs.Models;
using System.Data.Entity;

namespace AreasInAspDotNetMvcApps.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DatabaseConnectionStrongName")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        //DbSet Model
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
    }
}