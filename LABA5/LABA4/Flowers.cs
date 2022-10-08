using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    public sealed class Flowers : Сommodity, IFlowers // цветы
    {
        private static int Col = 0;
        private string Color;
        public string ColorFlower { get => Color; }

        public Flowers() { }
        public Flowers(int Cost, string Manufacturer, string Name, string Delivery, string Color, int Mass)
        {
            Col++;
            this.Color = Color;
            this.Manufacturer = Manufacturer;
            this.Delivery = Delivery;
            this.Cost = Cost;
            this.Name = Name;
            this.Mass = Mass;
        }
        public override string Info()
        {
            return "Данный продукт является: " + GetType().Name + ", он произведён: " + Manufacturer + ", название товара: " +
                Name + ", цена: " + Cost + ", доставка: " + Delivery + " вес цветка: " + Mass;
        }

        public override void ColСommodity()
        {
            Console.WriteLine("Создано " + Col + " объектa " + GetType().Name);
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Manufacturer + " " +
                   Name + " " + Delivery + " " +
                   Color + " " + Mass;
        }

        void IFlowers.ColСommodity() => Console.WriteLine("Создано " + Col + " объектa " + GetType().Name + " явная реализация интерфейса");



    }
}
