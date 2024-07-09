using ecomm.Models;
using Microsoft.EntityFrameworkCore;

namespace ecomm.Data
{
    public class EcommContext : DbContext
    {
        public EcommContext() 
        {
            
        }
        public EcommContext(DbContextOptions<EcommContext> options) : base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PO6TBST\\MYSERVER;database=Ecomm;User ID=sa;Password=hexor;Encrypt=True;TrustServerCertificate=True;");

        }

        public DbSet<Category> Categories { get; set; }
    }
}
