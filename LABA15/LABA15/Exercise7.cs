using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Exercise7
    {
        static BlockingCollection<string> bc = new BlockingCollection<string>(5);
        public static void Zad7()
        {
            Task[] sellers = new Task[5]
                    {
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Посудомоечная машина");
                    }
                }),
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(400);
                        bc.Add("Миксер");
                    }
                }),
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        bc.Add("Стиральная машина");
                    }
                }),
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(300);
                        bc.Add("Микроволновая печь");
                    }
                }),
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Робот-пылесос");
                    }
                })
            };
            foreach (var i in sellers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Количество товара на складе: {bc.Count}");
                Thread.Sleep(150);
                Thread thr = new Thread(Client);
                thr.Start();
            }
        }
        
        public static void Client()
        {
            if (bc.Count == 0)
            {
                Console.WriteLine("Покупатель ушёл, ничего не купив");
                return;
            }
            Console.WriteLine($"Покупатель купил {bc.Take()}");
        }
    }   
}
