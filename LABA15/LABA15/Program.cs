using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Exercise1.Ex1(100);
            try
            {
                Exercise2.Ex2(100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Exercise3_4.Volume();
            Exercise3_4.Value_4();
            Exercise5.Zad5_2();
            Exercise6.Zad6();
            Exercise7.Zad7();
            Exercise8.Zad8(2);
            Console.ReadKey();
        }
    }
}
