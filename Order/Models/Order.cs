using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Models
{
    public class Order:BaseEntity
    {
        //Establish the one to many relation between the order and the user
        public Guid UserId { get;set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Products.Sum(x => x.Price);
            }
        }
        public OrderStatus OrderStatus { get; set; }
        public DateTime Date { get; set; }
    }
    public enum OrderStatus
    {
        Cart = 0,
        Recieved = 1,
        Processed = 2,
        Finished = 3,
        Canceled = 4
    }
}
