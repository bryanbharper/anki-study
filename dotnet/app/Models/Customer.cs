using System.Collections.Generic;

namespace app.models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        public List<Order> Orders { get; set; }

    }
}