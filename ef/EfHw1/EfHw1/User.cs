﻿
namespace EfHw1
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ShoppingCart Cart { get; set; }
    }
}
