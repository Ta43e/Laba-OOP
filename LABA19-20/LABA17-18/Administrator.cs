using LABA17_18.Abstaract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public class Administrator : Template_Method, IBuy, IObservable
    {
        public string AdministratorName;
        private List<Product> ListProducts;
        public List<IObserver> observers;
        public Administrator(string administratorName)
        {
            AdministratorName = administratorName;
            ListProducts = new List<Product>();
            observers = new List<IObserver>();
        }

        public bool AddProduct(string Name, ITotalCost cost)
        {
            for (int i = 0; i < ListProducts.Count; i++)
            {
               if ( ListProducts[i].Name == Name)
                {
                    return false;
                }
            }
            Product product = new Product(Name, cost);
            ListProducts.Add(product);
            NotifyObservers();
            return true;
        }
        public void AddProductN(Product product)
        {
            ListProducts.Add(product);
            NotifyObservers();
        }
        public void PrintListProduct()
        {
            int tmp = 1;
            foreach (var item in ListProducts)
            {
                Console.WriteLine($"{tmp}. Продукт {item.Name}");
                tmp++;
            }
        }
        public List<Product> GetList()
        {
            return ListProducts;
        }

        public void BanClient(int Id)
        {
            for (int i = 0; i < OnlineStore.ListClient.Count; i++)
            {
                if (Id == OnlineStore.ListClient[i].Id)
                {
                    Console.WriteLine("Клиент успешно забанен!");
                    OnlineStore.ListClient.RemoveAt(Id);
                }
            }
            Console.WriteLine("Бан не удался!");
        }
        public void BuyProduct()
        {
            Console.WriteLine("Админ пытается что-то купить.");
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(ListProducts);
            }
        }

        public override void AddProductInShopping(List<Product> products)
        {
            Console.WriteLine("Список товаров");
            int x = 1;
            foreach (var product in products)   {
               
                Console.WriteLine($"{x}: {product.Name}");
                x++;
            }
            BuyProduct();

        }

        public override void Exet()
        {
            Console.WriteLine("Админ ушёл");
        }
    }
}
