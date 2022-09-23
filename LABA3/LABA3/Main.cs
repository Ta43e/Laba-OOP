using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA3;
using Nodes;

namespace LABA3
{
    internal class main
    {
        public static void Main()
        {
            MyList obj = new MyList();
            obj.Add("2");
            obj.Add("1");
            obj.Add("89");
            obj.PrintList();
            MyList list = new MyList();
            list.Add("88");
            list.Add("77");
            list.PrintList();
            MyList objNew = new MyList();
            objNew.Add("1");
            objNew.Add("2");
            objNew.Add("3");
            objNew.PrintList();
            obj += list;
            obj.PrintList();
            --list;
            list.PrintList();
            obj.PrintList();
            objNew.PrintList();
            Console.WriteLine(obj.Count + " " + objNew.Count);
            Console.WriteLine(obj == objNew);
            Console.WriteLine(objNew != objNew);
            Console.WriteLine(obj.LastNode());
            obj.PrintList();
            Console.WriteLine(obj.Count);
            obj.DeleteNode(4);
            obj.PrintList();
            Console.WriteLine("--------Вложеннык классы--------");
            MyList.Production production = new MyList.Production(23, "BSTU");
            MyList.Developer developer = new MyList.Developer(12, "Kozak Oleg D.", "FIT");
            Console.WriteLine("--------Статик метод классы--------");
            Console.WriteLine(StatisticOperation.ColElemen(obj));
            Console.WriteLine(StatisticOperation.DifMinMax(obj));
            Console.WriteLine(StatisticOperation.SumMinMax(obj));
            Console.WriteLine("-----------------------------------");
            obj.Sort(obj);
            obj.PrintList();
            Console.WriteLine(obj.Head.Next.Next.Next.Data);
            Console.WriteLine(StatisticOperation.MinE(obj));
            Console.WriteLine(StatisticOperation.MaxE(obj));
            Console.WriteLine("------------------------------------");
            String str = "Oleg Kozak";
            Console.WriteLine(str.ColBucv());
            obj.FirstE();
            obj.LastNode();
        }
    }
}
