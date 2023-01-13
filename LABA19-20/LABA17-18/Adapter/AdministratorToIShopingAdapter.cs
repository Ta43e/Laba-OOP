using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18.Adapter
{
    internal class AdministratorToShopAdapter : IShopping
    {
        Administrator administrator1;
        public AdministratorToShopAdapter(Administrator administrator)
        {
            administrator1 = administrator;
        }
        public void AddProductInShopping(List<Product> products)
        {
            administrator1.BuyProduct();
        }
    }
}
