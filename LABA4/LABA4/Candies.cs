using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public class Candies : Pastry // конфеты
    {
        private string CandiesName;
        private string CandiesDescription;
        public Candies(int Cost, string Manufacturer, string name, string delivery, string DateOfManufacture, string CandiesName, string CandiesDescription) : base(Cost, Manufacturer, name, delivery, DateOfManufacture)
        {
            this.CandiesName = CandiesName;
            this.CandiesDescription = CandiesDescription;
        }

        public override string Info()
        {
            return "Данный продукт является: " + GetType().Name + ", он произведён: " + Manufacturer + ", название товара: " +
                CandiesName + ", цена: " + Cost + ", доставка: " + CandiesDescription;
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Cost + " " + 
                   Manufacturer + " " +
                   Name + " " + DateOfManufacture + " " +
                   CandiesName + " " + CandiesDescription;
        }

    }
}
