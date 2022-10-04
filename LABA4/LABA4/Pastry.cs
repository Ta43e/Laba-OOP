using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public abstract class Pastry : Goods // выпечка
    {
        public string DateOfManufacture;
        public Pastry(int Cost, string Manufacturer, string name, string delivery, string DateOfManufacture) : base(Cost, Manufacturer, name, delivery)
        {
            this.DateOfManufacture = DateOfManufacture;
        }


    }
}
