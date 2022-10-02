using System;


namespace LABA1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Привет!---------------------");
            Console.WriteLine("Введите цифру");
            int _int = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Переменная типа int " + " = " + _int);
            bool chek = true;
            Console.WriteLine("bool = " + chek);
            byte byten = 230;
            Console.WriteLine("byte = " + byten);
            sbyte sbyten = -120;
            Console.WriteLine("sbyte = " + sbyten);
            short shorts = -32000;
            Console.WriteLine("short = " + shorts);
            ushort ushorts = 65000;
            Console.WriteLine("ushort = " + ushorts);
            long longs = 100;
            Console.WriteLine("long = " + longs);
            float floats = 1.777F;
            Console.WriteLine("float = " + floats);
            double doubles = 1.7777F;
            Console.WriteLine("double = " + doubles);
            decimal decimals = 1 / 4;
            Console.WriteLine("decimal = " + decimals);
            char chars = 'O';
            Console.WriteLine("char = " + chars);

            Console.WriteLine("Неявное приведение типов!");
            int a = 4;
            float b = a;
            Console.WriteLine("int -> float, b = " + b);
            long c = a;
            Console.WriteLine("int -> long, c = " + c);
            double d = a;
            Console.WriteLine("int -> double, d = " + d);
            double e = b;
            Console.WriteLine("float -> double, e = " + e);
            short _s = 10;
            int _a = _s;
            Console.WriteLine("short -> int, _a = " + _a);

            Console.WriteLine("Явное приведение типов!");
            double _b = 1.333;
            float flooat = (float)_b;
            Console.WriteLine("double -> float, flooat = " + flooat);
            int innt = Convert.ToInt32(flooat);
            Console.WriteLine("float -> int, innt = " + innt);
            char chaar = (char)innt;
            Console.WriteLine("int -> char, innt = " + chaar);
            byte byyte = (byte)chaar;
            Console.WriteLine("char -> byte, byyte = " + byyte);
            byyte = (byte)innt;
            Console.WriteLine("innt -> byte, byyte = " + byyte);

            Console.WriteLine("Упаковку и распаковку значимых типов");
            int box = 5;
            Object obj = box;
            Console.WriteLine((int)obj);
            byte byte_box = 12;
            Object obj2 = byte_box;
            Console.WriteLine((byte)obj2);
            short short_box = 10;
            Object obj4 = short_box;
            Console.WriteLine((short)obj4);
            long long_box = 20;
            Object obj5 = long_box;
            Console.WriteLine((long)obj5);
            float float_box = 12.332F;
            Object obj6 = float_box;
            Console.WriteLine((float)obj6);
            double d_box = 1.2313F;
            Object obj7 = d_box;
            Console.WriteLine((double)obj7);
            bool bool_box = false;
            Object obj8 = bool_box;
            Console.WriteLine((bool)obj8);
            char char_box = 'F';
            Object obj9 = char_box;
            Console.WriteLine((char)obj9);

            Console.WriteLine("Работа с неявно типизированной переменной");
            var randoms = 12;
            Console.WriteLine("var randoms = " + randoms);
            var random = "Привет!";
            Console.WriteLine("var random = " + random);

            Console.WriteLine("Пример работы Nullable");
            int? nullik = null;
            Console.WriteLine(" переменная int перед которой знак ? = " + nullik);
            //int nullik2 = null;

            //Console.WriteLine("Ошибка в var");
            //var test = 12;
            //test = (float)12.3F;
            //Console.WriteLine(test);`


            Console.WriteLine("-----------------Строки------------------");
            String str1 = "Лаба ";
            String str2 = "номер 1";
            String str3 = "Козак Олег";
            int result = string.Compare(str1, str2);
            if (result < 0) {
                Console.WriteLine("Строка str1 перед str2");
            }
            else if (result > 0) {
                Console.WriteLine("Строка str2 перед str1");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }

            Console.WriteLine("Конкатенация строк");
            Console.WriteLine(str1 + str2);

            Console.WriteLine("Копирование строки 2 = " + string.Copy(str2));
            Console.WriteLine("Обрезание строки 1 со второго символа до предпоследнего = " + str1.Substring(1, str1.Length - 1));
            Console.WriteLine("Разделении строки на слова");
            string[] words = str3.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Вставтка в строку: " + str1.Insert(5, str2));
            Console.WriteLine("Удаление заданной подстроки: " + str3.Remove(2, 3));
            Console.WriteLine($"str1 = {str1} str2 = {str2}");
            Console.WriteLine("Пустая строка");
            String strNull = null;
            String strempty = "";
            bool b1 = string.IsNullOrEmpty(strNull);
            bool b2 = string.IsNullOrEmpty(strempty);
            Console.WriteLine("Строка нулевая: " + b1);
            Console.WriteLine("Строка пустая: " + b2);
            Console.WriteLine(string.Compare(strempty, strNull));
            Console.WriteLine("SringBuilder");
            var strbild = new System.Text.StringBuilder("Привет Мир!)0)");
            strbild.Remove(2, 1);
            strbild.Remove(3, 1);
            strbild.Insert(0, 'Я');
            strbild.Insert(strbild.Length, 'A');
            Console.WriteLine(strbild.ToString());
            Console.WriteLine("--------------------Массивы---------------------");
            int[,] arr = new int[3,4] { { 0, 1, 2, 3}, { 4, 5, 6, 7}, { 8, 9, 10, 11} };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i,j] + " "); 
                }
                Console.WriteLine();
            }
            string[] stringarr = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            for (int k = 0; k < stringarr.Length; k++)
            {
                Console.Write(stringarr[k] + " ");
            }
            Console.WriteLine("Длина массива: " + stringarr.Length);
            Console.WriteLine("Введите номер элемента и позицию на которую поменять элемент");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            string tmp;
            tmp = stringarr[index];
            stringarr[index] = stringarr[id];
            stringarr[id] = tmp;
            Console.WriteLine("Результат!");
            for (int l = 0; l < stringarr.Length; l++)
            {
                Console.Write(stringarr[l] + " ");
            }
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            Console.WriteLine("Первая строка");
            for (int i = 0; i < myArr[0].Length; i++)
            {
                myArr[0][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вторая строка");
            for (int i = 0; i < myArr[1].Length; i++)
            {
                myArr[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Третья строка");
            for (int i = 0; i < myArr[2].Length; i++)
            {
                myArr[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < myArr[0].Length; i++)
            {
                Console.Write(myArr[0][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < myArr[1].Length; i++)
            {
                Console.Write(myArr[1][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < myArr[2].Length; i++)
            {
                Console.Write(myArr[2][i]);
            }
            Console.WriteLine();
            Console.WriteLine("Создайте неявно типизированные переменные для хранения массива и строки");
            var varArr = new int[5];
            var varString = "Ну вот, тута строка)))";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                varArr[i] = rnd.Next(0, 10);
                Console.Write(varArr[i] + " ");
            }
            Console.WriteLine();
            (int, string, char, string, ulong) Tuples = (12, "Это кортеж", 'O', "Всё так же кортеж", 2312);
            Console.WriteLine(Tuples);
            Console.WriteLine($"{Tuples.Item1} {Tuples.Item3} {Tuples.Item4}");
            Console.WriteLine("Распаковка кортежа");
            var tmp_int = Tuples.Item1;
            String tmp_string = Tuples.Item2;
            (int, string, char, string, ulong) Tuples1 = (12, "Это кортеж", 'O', "Всё так же кортеж", 2312);
            if (Tuples == Tuples1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            (int, int, int, String) checker(String str, int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[j] > arr[i])
                        {   
                            int tmp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = tmp;
                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {   
                    sum = sum + arr[i];
                }
                var result = (arr[0], arr[arr.Length - 1], sum, str.Substring(0, str.Length));
                return result;
            }
            var resultFoo = checker(str3, new int[] { 3, 5, 1, 10, 2, 8 });
            Console.WriteLine(resultFoo);

            Console.WriteLine("-----------Checked and Unchecked-------------");
            Checked_Unchecked();
            void Checked_Unchecked()
            {
            checked
            {
                int maxInt = int.MaxValue;
                Console.WriteLine(maxInt + 2);
            }
            unchecked
            {
                int maxUInt = int.MaxValue;
                Console.WriteLine(maxUInt + 2);
            }
            }


        }
    }
}
