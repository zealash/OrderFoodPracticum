using OrderAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    class MorningDessertRule : IOrderTypeRule
    {
        public void GetOrder(Order order)
        {
            if(order.DishTypes.Where(x => x == DishType.Dessert).Count() > 0)
            {
                order.ErrorMessage = "Invalid Order.";   
            }
        }
    }
}
