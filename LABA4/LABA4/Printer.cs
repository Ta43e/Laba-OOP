using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public class Printer
    {
        public virtual void IAmPrinting(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
