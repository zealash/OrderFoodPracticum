using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAgent
{
    public class Order
    {
        //public List<OrderItem> OrderItems { get; set; }

        public List<DishType> DishTypes { get; set; }

        public TimeOfDay TimeOfDay { get; set; }

        public Dictionary<DishType, List<string>> ReturnOrders = new Dictionary<DishType, List<string>>();

        public string ErrorMessage { get; set; }
    }

    public class OrderItem
    {
        public DishType DishType { get; set; }
        
        public TimeOfDay TimeOfDay { get; set; }

    }
}
