using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public sealed class Flowers : Сommodity, IFlowers // цветы
    {
        private static int Col = 0;
        private string Color;
         public string ColorFlower { get => Color; }

        public Flowers(int Cost, string Manufacturer, string name, string Delivery, string Color) : base(Cost, Manufacturer, name, Delivery)
        {
            Col++;
            this.Color = Color;
        }
        public override string Info()
        {
            return "Данный продукт является: " + GetType().Name + ", он произведён: " + Manufacturer + ", название товара: " +
                Name + ", цена: " + Cost + ", доставка: " + Delivery;
        }

        public override void ColСommodity()
        {
            Console.WriteLine("Создано " + Col + " объектa " + GetType().Name);
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Manufacturer + " " +
                   Name + " " + Delivery + " " +
                   Color;
        }

        void IFlowers.ColСommodity() => Console.WriteLine("Создано " + Col + " объектa " + GetType().Name + " явная реализация интерфейса");
    }
}
