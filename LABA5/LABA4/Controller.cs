using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    public static class Controller
    {
        private static Goods Item(int i, List<Object> list)
        {
            if (list[i] is Goods obj)
            {
                return obj;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public static void MinItemsInList(Container list)
        { 
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            int min = 0;
            dynamic obj = Item(0, list.List);
            for (int i = 0; i < list.List.Count - 1; i++)
            {
                if (Item(i, list.List).Mass < Item(i + 1, list.List).Mass)
                {
                    min = Item(i, list.List).Mass;
                    obj = Item(i, list.List);

                }
            }
            Console.WriteLine("Cамый легкий элемент подарка это: " + obj.GetType().Name + ", вес данного предмета составляет: " + obj.Mass);
        }
        public static void ObjectCreationfUsingJons(Container list)
        {
            list.PrintList();
        }
        public static Container StreamReaderL()
        {
            StreamReader file = new StreamReader("D:\\УНИК\\Семестр 3\\ООП\\LABA5\\Laba5.txt");
            Container list = new Container();
            {
                while(!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    if (line == "Cake")
                    {
                        list.Add(new Cake());
                    }
                    if (line == "Candies")
                    {
                        list.Add(new Candies());
                    }
                    if (line == "Flowers")
                    {
                        list.Add(new Flowers());
                    }
                    if (line == "Watch")
                    {
                        list.Add(new Watch());
                    }
                }
                return list;
            }
        }
        public static void ObjectCreationOfUsingJons(Container list)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
            };
            using var stream = new StreamReader(@"D:\УНИК\Семестр 3\ООП\LABA5\input.json");
            string JsonData = stream.ReadToEnd();

            List<Goods> deserializedList = JsonConvert.DeserializeObject<List<Goods>>(JsonData, settings);
            foreach (var item in deserializedList)
                list.Add(item);
        }

    }
}
