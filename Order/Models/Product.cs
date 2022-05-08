using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Models
{
    public class Product:BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string Name { get; set; }    
        public decimal Price { get; set; }
    }
}
