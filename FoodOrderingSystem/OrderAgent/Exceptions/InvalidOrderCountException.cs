using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAgent
{
    class InvalidOrderCountException : Exception
    {
        public InvalidOrderCountException()
        {
        }

        public InvalidOrderCountException(string message)
            : base(message)
        {
        }

        public InvalidOrderCountException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
