using OrderAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    class NightSideRule : IOrderTypeRule
    {
        public void GetOrder(Order order)
        {
            var sidesQuery = order.DishTypes.Where(x => x == DishType.Side);

            if (sidesQuery.Count() > 0)
            {
                List<string> sideItems = new List<string>();

                foreach (var dType in sidesQuery)
                {
                    sideItems.Add(FoodItems.Potato.ToString());
                }

                order.ReturnOrders.Add(DishType.Side, sideItems);
            }

        }
    }
}
