using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shop
{
    internal class Order
    {
        public List<Item> items { get; set; }
        public User orderby { get; set; }
        public int total_price { get; set; }

        public Order(User user)
        {
            items = null;
            orderby = user;
            total_price = 0;
        }
    }
}
