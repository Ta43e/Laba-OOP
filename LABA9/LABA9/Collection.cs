using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9
{
    public class Collection<T> : ISet<T> 
    {
        private LinkedList<T> _list;
        public int Count { get; }
        public Collection()
        {
            _list = new LinkedList<T>();
        }
        public bool IsReadOnly => throw new NotImplementedException();

        public bool Add(T item)
        {
            if (item == null) return false;
            _list.AddLast(item);
            return true;
        }

        public void Clear()
        {
            _list.Clear();
        }
        public void FindItem(T item)
        {
            if (_list.Find(item) == null) throw new Exception("Данного элемента не существует");
            Console.WriteLine(_list.Find(item).Value.ToString()); 
        }
        public void Print()
        {
            LinkedListNode<T> node = _list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value.ToString());
                node = node.Next; // next node
            }
        }
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (item == null) throw new ArgumentNullException("Невозможно удалить объект");
            _list.Remove(item);
            return true;
        }
        public bool SetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }
        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }
        public void UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }   
}
