using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    public interface IFlowers
    {
        string ColorFlower { get; }
        void ColСommodity();
    }
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
            if (Cost <= 0)
            {
                Col--;
                throw new ErrorInCost("Ошибка, цена не может быть меньше или равна 0", "Flowers", Cost);
            }
            if (Cost > 10000)
            {
                Col--;
                throw new Exception("Цена не может быть такой высокой");
            }
            this.Cost = Cost;
            this.Name = Name;
            if (Mass <= 0)
            {
                throw new ErrorInMass("Ошибка, масса не может быть меньше или равна 0", "Flowers", Mass);
            }
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

        public int TestProbros(int Cost)
        {
            throw new Exception("fff");
        }

        void IFlowers.ColСommodity() => Console.WriteLine("Создано " + Col + " объектa " + GetType().Name + " явная реализация интерфейса");



    }
}
