using LABA17_18.Abstaract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LABA17_18
{
    public abstract class BaseProduct
    {
        public string Name;
        public ITotalCost CostProduct;
        private double Cost;
        public BaseProduct(string name, ITotalCost costProduct)
        {
            Name = name;
            CostProduct = costProduct;
            Cost = costProduct.GetTotalCost();
        }
        public BaseProduct() { }
    }
}
