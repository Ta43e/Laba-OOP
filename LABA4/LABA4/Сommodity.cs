using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public abstract class Сommodity : Goods // продукт (не еда)
    {
        public Сommodity(int Cost, string Manufacturer, string name, string delivery) : base(Cost, Manufacturer, name, delivery)
        {
            
        }

        public abstract void ColСommodity();

    }
}
