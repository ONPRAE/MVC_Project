using Microsoft.EntityFrameworkCore;
using pjadv.Models;

namespace pjadv.Data
{
    public class advprojectsContext : DbContext
    {
        //Constructor
        public advprojectsContext(DbContextOptions<advprojectsContext> options) : base(options) { }

        public advprojectsContext() { }

        public DbSet<Project> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapping + จัดการ relations
            modelBuilder.Entity<Project>().ToTable("Products");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server = "localhost";
            string database = "*****";
            string uid = "*****";
            string password = "*****";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";PORT=3306;SslMode=Required;";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}
