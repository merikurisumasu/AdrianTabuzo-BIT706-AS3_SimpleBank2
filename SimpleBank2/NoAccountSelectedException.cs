using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank2
{
    public class NoAccountSelectedException : Exception
    {
        public NoAccountSelectedException(string message) :base(message)
        { }
    }
}
