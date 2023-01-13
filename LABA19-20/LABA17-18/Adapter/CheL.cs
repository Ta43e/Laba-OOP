using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public class CheL
    {
        Administrator administrator1;
        public CheL(Administrator administrator) 
        {
           administrator1 = administrator;
        }
        public void Pokupka(IShopping shopper)
        {
            shopper.AddProductInShopping(administrator1.GetList());
        }
    }
}
