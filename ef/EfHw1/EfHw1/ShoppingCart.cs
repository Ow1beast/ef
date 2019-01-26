using System.Collections.Generic;

namespace EfHw1
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public virtual ICollection<Product> Items { get; set; }
    }
}