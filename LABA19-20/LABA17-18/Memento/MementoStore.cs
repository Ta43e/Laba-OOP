using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public class MementoStore
    {
        private static string Name;
        public string GetName() { return Name; }

        private static List<Client> ListClient;
        public List<Client> GetList() { return ListClient; }
        public MementoStore(string name, List<Client> listClient)
        {
            Name = name;
            ListClient = listClient;
        }
    }
}
