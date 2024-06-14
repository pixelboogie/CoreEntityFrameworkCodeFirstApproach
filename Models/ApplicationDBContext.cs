using Microsoft.EntityFrameworkCore;

namespace CoreEntityFrameworkCodeFirstApproach.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            // She got server from SQL server manager???
            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirstDB;Integrated Securty=true TrustServerCertificate = true");
        }
    }
}
