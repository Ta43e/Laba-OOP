using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LABA2
{
    public class Class2
    {
        static void Main()
        {
            try
            {
                Car[] arrCar = new Car[10];
                Car car1 = new Car(1, "Re", 3, "Rino", "Red", 1000000, 12412);
                Car carDefolt = new Car();
                arrCar[0] = new Car(1, "Re", 3, "Rino", "Red", 1000000, 12412); 
                arrCar[1] = new Car(2, "Porshi", 5, "Pivo", "Green", 4200, 412); 
                arrCar[2] = new Car(3, "Pivo", 7,  "Uazik", "Green", 32000, 412);
                arrCar[3] = new Car(4, "Pivo", 9, "Lamba", "Green", 42000, 412);
                arrCar[4] = new Car(5, "Porshi", 1, "Tank", "Green", 42000, 412);
                arrCar[5] = new Car(6, "Porshi", 2, "Samolet", "Green", 42000, 412);
                arrCar[6] = new Car(7, "Porshi", 4, "Uazik", "Green", 42000, 412);
                arrCar[7] = new Car(8, "Porshi", 2, "Lamba", "Green", 42000, 412);
                arrCar[8] = new Car(5, "Porshi", 1, "Tank", "Green", 42000, 412);
                arrCar[9] = new Car(10, "Porshi",  2, "Pivo", "Green", 42000, 412);
                var VarCar = new { id = 1, name = "Re", cost = 3 };


                Console.WriteLine("------Автомабили одинаковой марки------");
                for (int i = 0; i < arrCar.Length; i++)
                {
                    if (String.Compare(arrCar[i]._name, "Porshi") == 0)
                    {
                        Console.WriteLine(arrCar[i].ToString() + "   " + arrCar[i].GetColCar());
                    }
                }

                Console.WriteLine("------Автомабили старше 3 лет------");
                for (int i = 0; i < arrCar.Length; i++)
                {
                    if (arrCar[i]._year > 3)
                    {
                        Console.WriteLine(arrCar[i].ToString() + "   " + arrCar[i].GetColCar());
                    }
                }

                Console.WriteLine("------Работа ref и out------");
                int cost1 = 1200;
                int result = car1.RefResult(ref cost1);
                Console.WriteLine(result);
                int resultOut;
                car1.TestOut(1000000, 12412, out resultOut);
                Console.WriteLine(resultOut);

                Console.WriteLine("------Сколько объектов создано------");
                Console.WriteLine(Car.InfoClass());

                Console.WriteLine("------Статический конструктор------");
                Console.WriteLine(Car._ColCar);



                Console.WriteLine("Закрытый конструктор");
                car1.TestPrivateConstructor();

                Console.WriteLine("Хеш");
                int result111 = car1.GetHashCode();
                Console.WriteLine(car1.GetHashCode());
                if (car1.GetHashCode() == arrCar[0].GetHashCode())
                {
                    Console.WriteLine("Они одинаковые по хешу");
                }
                else
                {
                    Console.WriteLine("Они разные по хешу");
                }
                if (car1.Equals(arrCar[2]))
                {
                    Console.WriteLine("Объекты одинаковые");
                }
                else
                {
                    Console.WriteLine("Они не одинаковые");
                }
                if (car1.Equals(arrCar[0]))
                {
                    Console.WriteLine("Объекты одинаковые");
                }
                else
                {
                    Console.WriteLine("Они не одинаковые");
                }
                Console.WriteLine("------readonly------");
                Console.WriteLine(car1.IdClass);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}


