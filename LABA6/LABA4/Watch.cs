using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    public class Watch : Сommodity // часы
    {
        public Watch(int Cost, string Manufacturer, string name, string Delivery, int Mass)
        {
            if (Cost <= 0)
            {
                throw new ErrorInCost("Цена не может быть меньше или равен  0", "Watch", Cost);
            }
            this.Manufacturer = Manufacturer;
            this.Name = name;
            this.Delivery = Delivery;
            this.Mass = Mass;
        }

        public Watch()
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
                   Name + " " + Delivery + " " + Mass;
        }
    }
}
