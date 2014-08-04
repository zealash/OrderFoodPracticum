using OrderAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    class MorningDrinkRule : IOrderTypeRule
    {
        public void GetOrder(Order order)
        {
            var drinkQuery = order.DishTypes.Where(x => x == DishType.Drink);

            if(drinkQuery.Count() > 0)
            {
                List<string> drinkItems = new List<string>();

                foreach (var dType in drinkQuery)
                {
                    drinkItems.Add(FoodItems.Coffee.ToString());
                }

                order.ReturnOrders.Add(DishType.Drink, drinkItems);
            }            
        }
    }
}
