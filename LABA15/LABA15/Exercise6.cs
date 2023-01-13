using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Exercise6
    {
        public static void Zad6()
        {
            Parallel.Invoke(
                Print,
                        () => Sum(),
                        () =>
                        {
                            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                        });
        }
        public static void Sum()
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
                Console.WriteLine($"Итерация {i + 1}: резкльтат: {sum}");
            }
        }
        public static void Print()
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
        }
    }
}
