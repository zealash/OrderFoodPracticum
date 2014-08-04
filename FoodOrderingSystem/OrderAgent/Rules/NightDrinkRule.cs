using OrderAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    class NightDrinkRule : IOrderTypeRule
    {
        public void GetOrder(Order order)
        {
            List<string> drinkItems = new List<string>() { FoodItems.Wine.ToString() };

            foreach (var dType in order.DishTypes.Where(x => x == DishType.Drink))
            {
                var existingOrder = order.ReturnOrders.Where(x => x.Key == DishType.Drink);

                if (existingOrder.Count() > 1)
                {
                    order.ErrorMessage = "Can not order more than one Drink.";
                }
                else
                {
                    order.ReturnOrders.Add(dType, drinkItems);
                }
            }
        }
    }
}
