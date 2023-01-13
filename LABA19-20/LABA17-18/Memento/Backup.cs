using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
    public class Backup
    {
        public Stack<MementoStore> History;
        public Backup()
        {
            History= new Stack<MementoStore>();
        }
    }
}
