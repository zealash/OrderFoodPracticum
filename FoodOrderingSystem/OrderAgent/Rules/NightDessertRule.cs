using OrderAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    class NightDessertRule : IOrderTypeRule
    {

        public void GetOrder(Order order)
        {
            List<string> dessertItems = new List<string>() { FoodItems.Cake.ToString() };

            foreach (var dType in order.DishTypes.Where(x => x == DishType.Dessert))
            {
                var existingOrder = order.ReturnOrders.Where(x => x.Key == DishType.Dessert);

                if (existingOrder.Count() > 1)
                {
                    order.ErrorMessage = "Can not order more than one Dessert.";
                }
                else
                {
                    order.ReturnOrders.Add(dType, dessertItems);
                }
            }
        }
    }
}
