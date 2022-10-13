using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    public class Container
    {
        public List<Object> list;

        public List<Object> List
        {
            get
            {
                return list;
            }
        }
        public Container()
        {
            list = new List<Object>();
        }

        public void Add(Object obj)
        {
            list.Add(obj);
        }
        public void Remove(int Index)
        {
            list.RemoveAt(Index);
        }
        public void PrintList()
        {
            Console.WriteLine("Вывод списка: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Элемент cписка " + i + ": " + list[i].ToString());
            }
        }
    }
}
