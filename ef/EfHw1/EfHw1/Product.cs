using System.Collections.Generic;

namespace EfHw1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<ShoppingCart> Carts { get; set; }
    }
}
