using LABA17_18.Abstaract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public class Product : BaseProduct, IClone
    {
        public string Name;
        public ITotalCost CostProduct;
        private double Cost;
        List<IObserver> observers;
        public Product(string name, ITotalCost costProduct) : base(name, costProduct)
        {
            Name = name;
            CostProduct = costProduct;
            Cost = costProduct.GetTotalCost();
            observers = new List<IObserver>();
        }
        public Product(string name, ITotalCost costProduct, Administrator administrator)
        {
            Name = name;
            CostProduct = costProduct;
            Cost = costProduct.GetTotalCost();
            administrator.AddProductN(this);
            observers = new List<IObserver>();
        }

        public Product()
        {
            observers = new List<IObserver>();
        }
        public Product(Product product)
        {
            Cost = product.GetCost();
        }
        public double SetCost(double cost) => Cost = cost; 
        public double GetCost() => Cost;
        public ITotalCost GetCostItem()
        {
            return CostProduct;
        }

        public string GetName() => Name;

        public ITotalCost GetCostProduct()
        {
            AbstractFactori factori = new ConcreteFactori();
            if (this.CostProduct.GetCost() * 0.15 <= this.CostProduct.GetTotalCost() + 0.1 || this.CostProduct.GetCost() * 0.15 >= this.CostProduct.GetTotalCost() - 0.1)
            {
                var Cost = factori.CreateTOtalCostMebel(this.CostProduct.GetCost());
                return Cost;
            }
            else
            {
                var Cost = factori.CreateTOtalCostElectro(this.CostProduct.GetCost());
                return Cost;
            }
            
        }
        public IClone Clone() => new Product(this);
    }
}
