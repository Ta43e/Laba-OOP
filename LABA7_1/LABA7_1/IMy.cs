using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7_1
{
    public interface IMy<T>
    {
        public void Add(T data);
        public void DeleteNode(int position);
        public void PrintList();
    }
}
