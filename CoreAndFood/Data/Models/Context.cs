using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6JUPUKR\\SQLEXPRESS; database=DbCoreFood; integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<Food> Foods { get; set; }  
        public DbSet<Category> Categories { get; set; }  
        public DbSet<Admin> Admins { get; set; }  
    }
}
