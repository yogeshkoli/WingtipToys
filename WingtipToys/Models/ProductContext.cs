using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        protected ProductContext() : base("WingtipToys")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set;}
    }
}