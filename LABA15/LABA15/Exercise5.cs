using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Exercise5
    {
        public static void Zad5_2()
        {
            Stopwatch watch1 = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();

            List<int> primes1 = new List<int>();
            List<int> primes2 = new List<int>();

            List<int> list = new List<int>(1000000000);
            Random random = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(random.Next(1, 20));
            }
            watch1.Start();
            ParallelLoopResult result = Parallel.ForEach<int>(list, Square);
            watch1.Stop();
            watch2.Start();
            foreach (var item in list)
            {
                Square(item);
            }
            watch2.Stop();
            Console.WriteLine($"Parallel.ForEach {watch1.ElapsedMilliseconds} msecs");
            Console.WriteLine($"ForEach {watch2.ElapsedMilliseconds} msecs");

        }
        private static void Square(int n)
        {
            n = n * n;
           for (int i = n - 1; i >= 0; i--)
            {
                i = i * i;
            }
        }
    }
}
