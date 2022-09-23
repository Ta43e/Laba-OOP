using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA3
{
    internal static class StatisticOperation
    {
        public static string MinE(MyList List1)
        {
            List1.Sort(List1);
            return List1.Head.Data;
        }

        public static string MaxE(MyList List1)
        {
            List1.Sort(List1);
            return List1.Tail.Data;
        }

        public static int SumMinMax(MyList List1)
        {
            int minE = Convert.ToInt32(MinE(List1));
            int maxE = Convert.ToInt32(MaxE(List1));
            return minE + maxE;
        }
        public static int DifMinMax(MyList List1)
        {
            int minE = Convert.ToInt32(MinE(List1));
            int maxE = Convert.ToInt32(MaxE(List1));
            return maxE - minE;
        }

        public static int ColElemen(MyList List1)
        {
            return List1.Count;
        }

        public static int ColBucv(this String str)
        {
            int ind = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    ind++;
                }
            }
            return ind;
        }

        public static void FirstE(this MyList List1)
        {
            Console.WriteLine("Первый элемент списка: " + List1.Head.Data);
        }


    }
}
