using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nodes;
namespace LABA7
{

    public class CollectionType<T, V>  : ListIntefeice<T> where T : Person<int> where V : Person<string>
    {
        private ArrayList MyArrayList;

        public ArrayList GetList { get { return MyArrayList; } }
        public CollectionType()
        {
            MyArrayList = new ArrayList();
        }

        public int Count
        {
            get
            {
                return MyArrayList.Count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T Item)
        {
            MyArrayList.Add(Item);

        }
        public void Add(V Item)
        {
            MyArrayList.Add(Item);
        }
        public bool Remove(int n)
        {
            if (n > Count || n < 0)
            {
                throw new Exception("Данный индекс является некорректным");
            }
            bool flag = false;
            for (int i = 0; i < Count; i++)
            {
                if (n == i)
                {
                    MyArrayList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool Remove(T Item)
        {
            bool flag = false;
            for (int i = 0; i < Count; i++)
            {
                if (MyArrayList[i].GetHashCode() == Item.GetHashCode())
                {
                    MyArrayList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool Contains(T Item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Item.GetHashCode() == MyArrayList[i].GetHashCode())
                {
                    return true;
                }
            }
            return false;
        }

        public CollectionType<T, V> CopyTo(CollectionType<T, V> List)
        {
            CollectionType<T, V> newlist = new CollectionType<T, V>();
            for (int i = 0; i < List.Count; i++)
            {
                newlist.GetList[i] = List.GetList[i];
            }
            return newlist;
        }
        public void CopyTo(T[] BusinessObjectArray, int index)
        {
            throw new Exception(
              "This Method is not valid for this implementation.");
        }
        public void Clear()
        {
            MyArrayList.Clear();
        }
        
        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Элемент " + i + ": " + MyArrayList[i].ToString());
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
