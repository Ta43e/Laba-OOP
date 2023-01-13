using LABA17_18.Abstaract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LABA17_18
{
    public class ColProduct : ProductDecorator
    {
        public ColProduct(BaseProduct baseProduct, Administrator administrator) : base(baseProduct, administrator)
        {
            Console.WriteLine("Это крутой придмет, на него доп скидка!");
            baseProduct.CostProduct.SetCost(baseProduct.CostProduct.GetCost() * 0.1);
            Product product = new Product(baseProduct.Name, baseProduct.CostProduct, administrator);
                                           
        }
    }
}
