using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    public class main
    {
        public static void Main(string[] args)
        {
            Goods cake = new Cake(112, "BSTU", "XZ", "13.01.2003", "OOO Dostavka.by", "Imperatriza");
            Console.WriteLine(cake.Info());
            Console.WriteLine(cake.ToString());
            Goods flower = new Flowers(112, "Kopei4ka", "Fialki", "Do domu", "Red");
            Console.WriteLine(flower.Info());
            Flowers flow2 = new Flowers(112, "Kopei4ka", "Fialki", "Do domu", "Red");
            //Console.WriteLine(flower.ColorFlower);
            Console.WriteLine(flow2.ColorFlower);
            //flower.ColСommodity();
            flow2.ColСommodity();
            if (flow2 is IFlowers flow2_1) flow2_1.ColСommodity();

            //========================//
            Goods watch = new Watch(1220, "Apple", "Elektronik", "BY Post");
            Console.WriteLine(watch.ToString());
            //=======================//
            Goods candies = new Candies(12, "Roshen", "Iriska", "BY ZaVOZ", "14.02.2022", "Ja Ebu", "Bez zukura");
            Console.WriteLine(candies.ToString());
            Console.WriteLine(candies.Info());
            //======================//
            IFlowers flowI = new Flowers(233, "Kopei4ka", "Rosi", "Do domu", "Red");

            if (flowI is Flowers flowT) flowT.Info();

            Goods[] goodsArr = new Goods[4];
            goodsArr[0] = new Cake(734, "BSTU", "XZ", "13.01.2003", "OOO Dostavka.by", "Imperatriza");
            goodsArr[1] = new Candies(12, "Roshen", "Iriska", "BY ZaVOZ", "14.02.2022", "Ja Ebu", "Bez zukura");
            goodsArr[2] = new Watch(1220, "Apple", "Elektronik", "BY Post");
            goodsArr[3] = new Flowers(904, "Kopei4ka", "Fialki", "Do domu", "Red");

            Printer printer = new Printer();
            Console.WriteLine("==============================================================");
            for (int i = 0; i < goodsArr.Length; i++)
            {
                printer.IAmPrinting(goodsArr[i]);
            }

        }
    }
}
