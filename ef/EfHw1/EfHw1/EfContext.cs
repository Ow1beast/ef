using System.Data.Entity;

namespace EfHw1
{
    public class EfContext : DbContext
    {
        public EfContext() : base("name=EfContext") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingCart> Carts { get; set; }
    }
}