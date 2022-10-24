using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9
{
    public class Image
    {
        private string name;
        public string Name { get { return name; } }
        private string author;
        public string Author { get { return author; } }

        public Image (string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public override string ToString()
        {
            return GetType().Name + " name: " + name + " author: " + author;
        }
    }
}
