using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_13
{
    [Serializable]
    public class Cake : Goods // тортики
    {
        private string CakeName;
        public Cake(int Cost, string Manufacturer, string name, string delivery, string CakeName) : base(Cost, Manufacturer, name, delivery)
        {
            this.CakeName = CakeName;
        }

        public Cake() : base() { }
        public override string Info()
        {
            return "Данный продукт является: " + GetType().Name + ", он произведён: " + Manufacturer + ", название товара: " +
                CakeName + ", цена: " + Cost + ", доставка: " + Delivery;
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Manufacturer + " " +
                   Name + " " +
                   CakeName + " " + Delivery + " " + CakeName;
        }
        public override int GetHashCode()
        {
            return CakeName.GetHashCode() + Cost.GetHashCode() + Manufacturer.GetHashCode() + Delivery.GetHashCode() + Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Cake m = obj as Cake;
            if (m as Cake == null) return false;
            return this.Cost == m.Cost && this.Manufacturer == m.Manufacturer && this.Name == m.Name &&
                   this.Delivery == m.Delivery && this.Manufacturer == m.Manufacturer;
        }
    }
}
