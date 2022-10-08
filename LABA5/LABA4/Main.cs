using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LABA5
{
    public class main
    {
        public static void Main(string[] args)
        {
            Container objTest = new Container();
            Goods cake = new Cake(112, "BSTU", "XZ", "13.01.2003", "OOO Dostavka.by", "Imperatriza", 1200);
            Goods flower = new Flowers(112, "Kopei4ka", "Fialki", "Do domu", "Red", 123);
            Goods flow2 = new Flowers(112, "Kopei4ka", "Fialki", "Do domu", "Red", 122);
            //========================//
            Goods watch = new Watch(1220, "Apple", "Elektronik", "BY Post", 320);
            //=======================//
            Goods candies = new Candies(12, "Roshen", "Iriska", "BY ZaVOZ", "14.02.2022", "Ja tut", "Bez zukura", 222);
            //======================//
            //-------------Задание 1------------------//
            Person person = new Person("Oleg", 12);
            person.Print();
            Console.WriteLine("===========================================================");
            //-------------Задание 3-4------------------//



            Container obj = new Container();
            obj.Add(watch);
            obj.Add(flow2);
            obj.Add(cake);
            objTest.Add(watch);
            objTest.Add(flow2);
            obj.PrintList();
            Controller.MinItemsInList(obj);
            Console.WriteLine("===========================================================");
            Container obj2;
            obj2 = Controller.StreamReaderL();
            obj2.PrintList();

            
            Controller.ObjectCreationfUsingJons(objTest);
            objTest.PrintList();
        }
    }
}
