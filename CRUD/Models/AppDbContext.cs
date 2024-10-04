using System.Data.Entity;

namespace CRUD.Models
{
    public class AppDbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}