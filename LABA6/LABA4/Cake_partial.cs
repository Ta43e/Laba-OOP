using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    public partial class Cake
    {
        static Cake()
        {
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Manufacturer + " " +
                   Name + " " + DateOfManufacture + " " +
                   CakeName + " " + Delivery + " " + Mass;
        }
        public override int GetHashCode()
        {
            int hash = GetHashCode();
            hash = 31 * hash + CakeName.GetHashCode();
            hash = 31 * hash + Cost.GetHashCode();
            hash = 31 * hash + Manufacturer.GetHashCode();
            hash = 31 * hash + Name.GetHashCode();
            hash = 31 * hash + Delivery.GetHashCode();
            hash = 31 * hash + DateOfManufacture.GetHashCode();
            return hash;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Cake m = obj as Cake;
            if (m as Cake == null) return false;
            return this.Cost == m.Cost && this.Manufacturer == m.Manufacturer && this.Name == m.Name &&
                   this.Delivery == m.Delivery && this.DateOfManufacture == m.DateOfManufacture && this.Manufacturer == m.Manufacturer;
        }
    }

}
