using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public class OnlineStore
    {
        private static string Name;
        public static List<Client> ListClient;
        public OnlineStore (string name)
        {
            Name = name;
            ListClient = new List<Client> ();
        }
        public void AddClient(Client client)
        {
            ListClient.Add(client);
            Console.WriteLine("Вы успешно зарегестрировались");
        }
        public bool DeliteClientList(int Id)
        {
            bool chak = false;
            if (ListClient == null || Id < 0)
            {
                return chak;
            }
            else
            {
                for (int i = 0; i < ListClient.Count; i++)
                {
                    if (ListClient[i].Id == Id)
                    {
                        Client client = ListClient[i];
                        ListClient.Remove(client);
                        chak = true;
                    }
                }
            }
            return chak;
         }
        public void PrintListClient()
        {
            int tmp = 1;
            Console.WriteLine("-------------------------Список клиентов-------------------------");
            foreach (var item in ListClient)
            {
                Console.WriteLine($"{tmp}. Клиент: {item.GetName()}. Статус клиента {Convert.ToString(item.GetStatusClient())}");
                tmp++;
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
        public MementoStore Save()
        {
            Console.WriteLine($"Резервная копия магазина создана! Колличество клиентов {ListClient.Count}");
            List<Client> newList = new List<Client>();
            foreach (var item in ListClient)
            {
                newList.Add(item);
            }

            return new MementoStore(Name, newList);
        }
        public void RestoreState(MementoStore memento)
        {
            Name = memento.GetName();
            ListClient = memento.GetList();
            Console.WriteLine($"Резервная копия восстановлена! Колличество клиентов {ListClient.Count}");
        }



    }
}
