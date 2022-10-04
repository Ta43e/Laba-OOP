using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public class Watch : Сommodity // часы
    {
        public Watch(int Cost, string Manufacturer, string name, string Delivery) : base(Cost, Manufacturer, name, Delivery)
        {
            
        }
        public override string Info()
        {
            throw new NotImplementedException();
        }

        public override void ColСommodity()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return GetType().Name + ": " + Manufacturer + " " +
                   Name + " " + Delivery;
        }
    }
}
