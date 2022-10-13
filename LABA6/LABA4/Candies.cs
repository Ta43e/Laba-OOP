using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    public class Candies : Pastry // конфеты
    {
        private string CandiesName;
        private string CandiesDescription;

        public Candies() {}

        public Candies(int Cost, string Manufacturer, string name, string delivery, string DateOfManufacture, string CandiesName, string CandiesDescription, int Mass)
        {
            if (Cost <= 0)
            {
                throw new ErrorInCost("Цена не может быть меньше или равен  0", "Candies", Cost);
            }
            this.Manufacturer = Manufacturer;
            this.Name = name;
            this.Delivery = delivery;
            this.DateOfManufacture = DateOfManufacture;
            this.CandiesName = CandiesName;
            this.CandiesDescription = CandiesDescription;
        }

        public override string Info()
        {
            return "Данный продукт является: " + GetType().Name + ", он произведён: " + Manufacturer + ", название товара: " +
                CandiesName + ", цена: " + Cost + ", доставка: " + CandiesDescription + " вес конфеты: " + Mass;
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Cost + " " + 
                   Manufacturer + " " +
                   Name + " " + DateOfManufacture + " " +
                   CandiesName + " " + CandiesDescription + " " + Mass;
        }

    }
}
