using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7_1
{
    public class Test<T> where T : class
    {
        T[] mass;
        private int count = 0;
        public Test()
        {
            mass = new T[3];
        }

        public void AddMass(T item)
        {
            mass[count] = item;
            count++;
        }

        public void PrintMass()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
    }
}
