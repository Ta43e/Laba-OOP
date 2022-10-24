using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7_1
{
    public class main
    {
        public static void Main()
        {
            try
            {
                MyList<int> obj = new MyList<int>();
                obj.Add(3);
                obj.Add(1);
                obj.Add(2);
                obj.PrintList();
                MyList<char> list = new MyList<char>();
                list.Add('B');
                list.Add('A');
                list.Add('C');
                list.PrintList();
                MyList<string> objNew = new MyList<string>();
                objNew.Add("Oleg2");
                objNew.Add("Oleg1");
                objNew.Add("Oleg3");
                objNew.PrintList();

                obj.Sort(obj);
                obj.PrintList();
                list.Sort(list);
                list.PrintList();
                //objNew.Sort(objNew);
                //objNew.PrintList();
                //---------------------//
                Person<int> person = new Person<int>("FFF", 123);
                Person<int> personInt = new Person<int>("Oleg11", 1223);
                Person<string> personString = new Person<string>("Oleg11", "Oleg12");
                Console.WriteLine(personInt.ToString());
                Console.WriteLine(personString.ToString());
                MyList<int> objJson = new MyList<int>();
                json<int>.Ser(obj);
                json<int>.Der(objJson);
                objJson.PrintList();
                //----------------------//
                Test<Person<string>> test = new Test<Person<string>>();
                test.AddMass(personString);
                test.PrintMass();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Конец работы программы");
            }

        }
    }
}
