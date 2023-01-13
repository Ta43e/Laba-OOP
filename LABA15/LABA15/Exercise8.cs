using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Exercise8
    {
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            Thread.Sleep(100);
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static async void Zad8(int n)
        {
            Console.WriteLine($"Начат подсчет {n}-го числа Фибоначчи");
            var result = Task<int>.Factory.StartNew(() => Fibonacci(n));
            int value = await result;
            Console.WriteLine($"Результат: {value}");
        }
    }
}
