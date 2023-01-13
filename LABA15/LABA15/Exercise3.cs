using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Exercise3_4
    {
        public static double NumA(int n)
        {
            return n * 3.14;
        }
        public static double NumB()
        {
            return 0.75;
        }
        public static double NumC(int n)
        {
            return n * n;
        }
        public static double Volume()
        {
            var tas1 = Task<double>.Factory.StartNew(() => NumA(12));
            var tas2 = Task<double>.Factory.StartNew(() => NumB());
            var tas3 = Task<double>.Factory.StartNew(() => NumC(12));
            var taskList = new List<Task> { tas1, tas2, tas3 }; 
            var tas4 = Task<double>.Factory.ContinueWhenAll(taskList.ToArray(), res =>
            {
                return tas1.Result * tas2.Result * tas3.Result;
            });
            Console.WriteLine(tas4.Result);
            return tas4.Result;
        }
        public static void Value_4()
        {
            var tas1 = Task<double>.Factory.StartNew(() => NumA(12));
            var awaiter = tas1.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                double res = awaiter.GetResult() * 0.75 * 12 * 12;
                Console.WriteLine("Результат: " + res);
            });
          
        }
    }
}
