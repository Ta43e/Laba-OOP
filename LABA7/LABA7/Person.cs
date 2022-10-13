using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7
{
    public class Person<T>
    {
        public string Name;
        public T password;
        public Person(string name, T password)
        {
            Name = name;
            this.password = password;
        }

        public override string ToString()
        {
            return GetType().Name + " " + "Name" +
                Name + " " + "password" + " " + password;
        }

        public override int GetHashCode()
        {
            int Hach = GetHashCode();
            Hach = 31 * Hach * Name.GetHashCode();
            Hach = 31 * Hach * password.GetHashCode();
            return Hach;
        }
    }
}
