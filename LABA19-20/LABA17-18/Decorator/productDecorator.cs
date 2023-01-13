using LABA17_18.Abstaract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public abstract class ProductDecorator : BaseProduct
    {
        protected BaseProduct baseProduct;
        public ProductDecorator(BaseProduct baseProduct, Administrator administrator) : base(baseProduct.Name, baseProduct.CostProduct)
        {
            this.baseProduct = baseProduct;
        }
    }
}
