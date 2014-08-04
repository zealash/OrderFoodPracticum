using System;
namespace OrderAgent
{
    public interface IOrderFood
    {
        /// <summary>
        /// Get Order based on the input
        /// </summary>
        /// <param name="orderParams">array of strings that consists of TimeOfDay and DishTypes</param>
        /// <returns>string output based on the input</returns>
        string GetOrder(string[] orderParams);
    }
}
