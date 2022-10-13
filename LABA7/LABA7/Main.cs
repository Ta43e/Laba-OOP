using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nodes;

namespace LABA7
{
    internal class main
    {
        public static void Main()
        {
            CollectionType<Person<int>, Person<string>> list = new CollectionType<Person<int>, Person<string>>();
            Person<int> persin1 = new Person<int>("oLEG", 123);
            Person<string> persin2 = new Person<string>("oLEG", "Oleg123");
            Person<int> persin3 = new Person<int>("oLEG", 123);
            list.Add(persin1);
            list.Add(persin2);
            list.Add(persin3);
            list.Print();

        }
    }
}
