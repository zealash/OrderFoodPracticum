using OrderAgent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    public class MorningSideRule : IOrderTypeRule
    {
        public void GetOrder(Order order)
        {
            List<string> sideItems = new List<string>() { FoodItems.Toast.ToString() };

            foreach (var dType in order.DishTypes.Where(x => x == DishType.Side))
            {
                var existingOrder = order.ReturnOrders.Where(x => x.Key == DishType.Side);

                if (existingOrder.Count() > 1)
                {
                    order.ErrorMessage = "Can not order more than one Side.";
                }
                else
                {
                    order.ReturnOrders.Add(dType, sideItems);
                }
            }
        }
    }
}
