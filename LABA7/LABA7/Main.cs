using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace LABA7
{
    internal class main
    {
        public static void Main()
        {
            try
            {
                CollectionType<Person<int>, Person<string>> list = new CollectionType<Person<int>, Person<string>>();
                Person<int> persin1 = new Person<int>("234", 123);
                Person<string> persin2 = new Person<string>("B", "Oleg123");
                Person<int> persin3 = new Person<int>("C", 223123);
                Person<string> persin4 = new Person<string>("D", "Password123");
                list.Add(persin1);
                list.Add(persin2);
                list.Print();
                Console.WriteLine(list.Find(persin2));
                //GenericsAndFiles.WriteList<CollectionType<Person<int>, Person<string>>>(list);
                //CollectionType<Person<int>, Person<string>>? Jlist = JsonConvert.DeserializeObject<CollectionType<Person<int>, Person<string>>>(list.GetList.ToString());
                using (FileStream fs = new FileStream(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA7\test.json", FileMode.OpenOrCreate))
                {
                    Person<int> tom = new Person<int>("Tom", 37);
                    JsonSerializer.Serialize<Person<int>>(fs, tom);
                    Console.WriteLine("Data has been saved to file");
                }
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Конец работы");
            }


        }
    }
}
