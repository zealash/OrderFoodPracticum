using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAgent.Interfaces
{
    public interface IOrderTypeRule
    {
        void GetOrder(Order order);
    }
}
