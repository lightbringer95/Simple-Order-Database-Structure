using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Models
{
    //Inherit the primary key from base entity
    public class User:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
