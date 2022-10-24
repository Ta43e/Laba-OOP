using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7_1
{
    public class Person<T>
    {
        public string Name;
        private T password;

        public T Password { get { return password; } set { password = value; } }

        public Person(string name, T password)
        {
            Name = name;
            this.password = password;
        }

        public override string ToString()
        {
            return GetType().Name + " " + "Name " +
                Name + " " + "password" + " " + password;
        }

        public override bool Equals(object? obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            Person<T> test = obj as Person<T>;
            if (test as Person<T> == null)
            {
                return false;
            }
            return test.Name == this.Name && EqualityComparer<T>.Default.Equals(test.password, this.password);
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
