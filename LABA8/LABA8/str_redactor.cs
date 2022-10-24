using System.Text.RegularExpressions;
using System;

namespace LABA8
{
    public static class strEditor
    {
        public static string str;
        public static void Remove()
        {
            str = Regex.Replace(str, @"[,{}№$#/\.:;!?-]", "");
            Console.WriteLine(str);
        }

        public static void ToUpperCase()
        {
            str = str.ToUpper();
            Console.WriteLine(str);
        }

        public static void ToLowerCase()
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }

        public static void RemoveSpaces()
        {
            str = Regex.Replace(str, @"(\s)+", " ");
            Console.WriteLine(str);
        }

        public static void AddQuestion()
        {
            str = str.Insert(str.Length, "?");
            Console.WriteLine(str);
        }
    }
}