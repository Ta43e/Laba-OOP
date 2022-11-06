using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA11
{
    delegate void Print(List<string> list);
    public class Programm
    {
        public static void Main()
        {
            Print print = delegate (List<string> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            };
            Production production = new Production(12, "BSTU");
            Car car = new Car(14, "Pivo", 2002, "Tank", "Green", 23000, 432);
            Reflector.NameAssembler("LABA11.Car");
            Console.WriteLine("---------------------");
            Reflector.GetConstructors("LABA11.Car");
            Console.WriteLine("---------------------");
            Reflector.NameAssembler("LABA11.Production");
            Console.WriteLine("---------------------");
            Reflector.GetConstructors("LABA11.Production");

            Console.WriteLine("----------Method---------");
            print.Invoke((List<string>)Reflector.CheckMetod("LABA11.Car"));
            Console.WriteLine("---------------------");
            print.Invoke((List<string>)Reflector.CheckMetod("LABA11.Production"));

            Console.WriteLine("-----------InfoPole----------");
            print.Invoke((List<string>)Reflector.InfoPole("LABA11.Car"));
            Console.WriteLine("---------------------");
            //print.Invoke((List<string>)Reflector.InfoPole("Production"));
            Console.WriteLine("--------InfoInterfese----------");
            print.Invoke((List<string>)Reflector.InfoInterfeice("LABA11.Car"));
            Console.WriteLine("---------------------");
            print.Invoke((List<string>)Reflector.InfoInterfeice("LABA11.Production"));

            Console.WriteLine("---------------------");
            Reflector.InfoParametr("LABA11.Car", "Int32");
            Console.WriteLine("---------------------");
            Reflector.InfoParametr("LABA11.Production", "Int32");
            Console.WriteLine("============================");
            Reflector.Invoke("LABA11.Production", "TestLaba");
            Console.WriteLine("============================");




            Object obj = Reflector.Create("LABA11.Production");
            Console.WriteLine(obj.GetType().Name);
            Reflector.NameAssembler("System.Object");
            Reflector.InfoInterfeice("System.Object");
            Reflector.GetConstructors("System.Object");
        }
    }
}
