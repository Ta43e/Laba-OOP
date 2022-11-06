using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA10
{
    public class Programm
    {
        public static void Main()
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var res1 = from p in month
                       where p.Length == 4
                       select p;
            foreach (var p in res1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------------------------------------");
            var res2 = from m in month
                             where Array.IndexOf(month, m) < 2 ||
                             Array.IndexOf(month, m) > 4 && Array.IndexOf(month, m) < 8 ||
                             Array.IndexOf(month, m) == 11
                             select m;
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------------");
            var res3 = from b in month
                       orderby b 
                       select b;
            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------------");
            var res4 = from c in month
                       where c.Length >= 4 && c.Contains('u')
                       select c;
            foreach (var item in res4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------------");
            List<Car> list = new List<Car>();
            list.Add(new Car(1, "Re", 3, "Rino", "Red", 1000000, 12412));
            list.Add(new Car(2, "Re", 3, "Rino", "Red", 1000000, 12412));
            list.Add(new Car(3, "Porshi", 5, "Pivo", "Green", 4200, 412));
            list.Add(new Car(4, "Pivo", 7, "Uazik", "Green", 32000, 412));
            list.Add(new Car(5, "Pivo", 9, "Lamba", "Green", 22000, 412));
            list.Add(new Car(6, "Porshi", 1, "Tank", "Green", 32000, 412));
            list.Add(new Car(7, "Porshi", 2, "Samolet", "Green", 12000, 412));
            list.Add(new Car(8, "Porshi", 4, "Pivo", "Green", 42000, 412));
            list.Add(new Car(9, "Porshi", 2, "Lamba", "Green", 42000, 412));
            list.Add(new Car(10, "Porshi", 1, "Tank", "Green", 42000, 412));
            Console.WriteLine("---------------------------------------------------------");
            var res5 = from g in list
                       where g._model == "Rino"
                       select g;
            foreach (var item in res5)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            var res6 = from k in list
                       where k._model == "Pivo" && k._year > 3
                       select k;
            foreach (var item in res6)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            var res7 = from a in list
                       where a._color == "Green" && a._cost > 10000 && a._cost < 40000
                       select a;
            foreach (var item in res7)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            var res8 = from s in list where s._year == list.Max(s => s._year) select s;
            foreach (var item in res8)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--------------------------------------------------------");
            var res9 = (from f in list orderby f._year select f).Take(5);
            foreach (var item in res9)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            var res10 = (from f in list orderby f._cost select f);
            foreach (var item in res10)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            var myRequest = (from l in list
                             orderby l._name
                             where l._cost < 25000 || l._model == "Pivo"
                             select new { Name = l._name, Cost = l._cost, Model = l._model, Color = l._color }).All(l => l.Color.Equals("Green"));
            if (myRequest)
            {
                Console.WriteLine("Такой автомобиль есть, можно покупать!");
            }
            else
            {
                Console.WriteLine("Жаль, такого авто у нас нету(");
            }
            Console.WriteLine("---------------------------------------------------------");
            var myRequestJoin = (from i in list
                             orderby i._name
                             where i._cost < 25000 || i._model == "Pivo"
                             select new { Name = i._name, Cost = i._cost, Model = i._model + "oLEG!!!", Color = i._color, Id = 1324124123});
            foreach (var item in myRequestJoin)
            {
                Console.WriteLine($"Name = {item.Name}, Cost = {item.Cost}, Model = {item.Model}, Color = {item.Color}");
            }
            Console.WriteLine("---------------------------------------------------------");
            var myJoin = from y in list join c in myRequestJoin on y._name equals c.Name select new { Name = y._name, Cost = y._cost, Model = c.Model, Color = y._color, Id = c.Id };
            foreach (var item in myJoin)
            {
                Console.WriteLine($"Name = {item.Name}, Cost = {item.Cost}, Model = {item.Model}, Color = {item.Color}, Id = {item.Id}");
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(myJoin.Count());
            Console.WriteLine(list.Count);
        }
    }
}
