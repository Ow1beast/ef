using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfHw1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EfContext())
            {
                Category category = new Category
                {
                    Name = "category1"
                };

                var user = new User
                {
                    Login = "Login1",
                    Password = "Pass1"
                };

                var cart = new ShoppingCart
                {
                   
                };

                user.Cart = cart;

                var item = new Product
                {
                    Name = "Product 1 Name",
                    Price = 300,
                    Carts = new List<ShoppingCart>
                    {
                        cart
                    }
                };

                item.Category = category;

                cart.Items = new List<Product>
                {
                    item
                };

                context.Carts.Add(cart);
                context.Users.Add(user);
                context.Products.Add(item);

                context.SaveChanges();
            }
        }
    }
}
