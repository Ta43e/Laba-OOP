using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA10
{
    public class Car
    {
        private int id; //
        private string name; //
        private string model; //
        private int year; //
        private string color; //
        private int cost; // 
        private int RegId; //
        private static int ColCar = 12;
        public readonly int IdClass;
        private static int ColVoOBJ = 0;
        public int hachcode;

        public int _id
        {
            get
            {
                return id;
            }
        }

        public string _name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int _year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string _model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string _color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int _cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public static int _ColCar
        {
            get
            {
                return ColCar;
            }
        }

        static Car()
        {
            ColCar--;
        }

        private Car(int id)
        {
            id = 8;
            Console.WriteLine("Закрытый конструктор");
        }

        public Car()
        {
            id = 12;
            name = "Puschka";
            year = 2;
            model = "Ij-12";
            color = "Grean";
            cost = 16000;
            RegId = 14034;
            ColVoOBJ++;
        }

        public Car(int id, string name, int year, string model, string color, int cost, int RegId)
        {   
            if(id <= 0 || year <= 0 || cost <= 0 || RegId <= 0)
            {
                throw new ArgumentException();
            }
            this.id = id;
            this.name = name;
            this.year = year;
            this.model = model;
            this.color = color;
            this.cost = cost;
            this.RegId = RegId;
            IdClass = GetHashCode();
            ColVoOBJ++;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Car car = obj as Car; // можно ли привести
            if (car as Car == null)
            {
                return false;
            }
            return car.id == this.id && car.name == this.name && car.model == this.model && car.color == this.color && car.cost == this.cost && car.year == year && car.RegId == RegId;
        }

        public override int GetHashCode()
        {
            hachcode = id.GetHashCode();
            hachcode = 31 * name.GetHashCode();
            hachcode = 31 * model.GetHashCode();
            hachcode = 31 * year.GetHashCode();
            hachcode = 31 * color.GetHashCode();
            hachcode = 31 * cost.GetHashCode();
            hachcode = 31 * RegId.GetHashCode();
            return hachcode;
        }

        public override string ToString()
        {
            return "Car. " +
                   "id:" + id + ", " +
                   "name: " + name + ", " +
                   "model: " + model + ", " +
                   "year: " + year + ", " +
                   "color: " + color + ", " +
                   "cost: " + cost + ", " +
                   "RegId: " + RegId;
        }
        public int GetYear()
        {
            return year;
        }
        public int GetColCar()
        {
            return ColCar;
        }

        public static int InfoClass()
        {
            return ColVoOBJ;
        }
        public void TestOut(int id, int cost, out int resultat)
        {
            resultat = id + cost;
        }
        public int RefResult (ref int cost)
        {
            cost = cost / 2;
            return cost;
        }

        public int TestPrivateConstructor()
        {
            Console.WriteLine("------Работа приватного конструктора------");
            Car privateCar = new Car(23);
            return privateCar._id;
        }

    }
}
