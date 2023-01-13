using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public abstract class Template_Method
    {
        public void Shopping(List<Product> products)
        {
            AddProductInShopping(products);
            Exet();
        }
        public abstract void AddProductInShopping(List<Product> products);
        public abstract void Exet();
    }
}
