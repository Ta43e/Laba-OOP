using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LABA7_1
{

    public class MyList<T> : IMy<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        public Node Head;
        public Node Tail;

        private int count;
        public int Count
        {
            get { return count; }
        }
        public void Add(T data)
        {
            Node node = new Node
            {
                Data = data
            };

            if (Head == null)
            {
                Head = node;
            }

            else
            {
                Tail.Next = node;
            }
            Tail = node;
            count++;
        }
        public void PrintList()
        {
            Node node = Head;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }

        public T LastNode()
        {

            return this.Tail.Data;
        }
        public void DeleteNode(int position)
        {
            if (count == 0 || position >= count || position < 0)
            {
                throw new Exception("Неверный ввод");
            }
            int tmp = 0;
            if (position == 0)
            {
                this.Head = this.Head.Next;
                count--;
            }
            else if (position == count - 1)
            {
                Node tmpNode = GetNode(position);
                count--;
                Tail = tmpNode;
                tmpNode.Next = null;

            }
            else
            {
                Node previousNode = GetNode(position);
                while (true)
                {
                    if (tmp == position)
                    {
                        previousNode.Next = previousNode.Next.Next;
                        count--;
                        break;
                    }
                    else
                    {
                        tmp++;
                    }

                }
            }
        }
        public Node GetNode(int pos)
        {
            Node previousNode = Head;
            for (int i = 0; i < pos - 1; i++)
            {
                previousNode = previousNode.Next;
            }
            return previousNode;
        }
        public T Sort(MyList<T> List1)
        {
            try 
            {
                Node tmps = List1.Head;
                for (int i = 0; i < List1.Count; i++)
                {
                    List1.Head = tmps;
                    for (int j = 0; j < List1.Count; j++)
                    {
                        if (List1.Head.Next == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (Convert.ToInt32(List1.Head.Data) > Convert.ToInt32(List1.Head.Next.Data))
                            {
                                T tmp = List1.Head.Data;
                                List1.Head.Data = List1.Head.Next.Data;
                                List1.Head.Next.Data = tmp;
                            }
                        }
                        List1.Head = List1.Head.Next;
                    }
                }
                List1.Head = tmps;
                return List1.Head.Data;
            }
            catch
            {
                throw new Exception("Сортировка строк не предусмотрена))");
            }

        }

        public static MyList<T> operator +(MyList<T> List1, MyList<T> List2)
        {
            List1.Tail.Next = List2.Head;
            List1.Tail = List2.Tail;
            List1.count += List2.count;
            return List1;
        }
        public static MyList<T> operator --(MyList<T> List1)
        {

            List1.Head = List1.Head.Next;
            List1.count--;
            return List1;
        }
        public static bool operator true(MyList<T> List1)
        {
            if (List1.count != 0)
            {
                while (List1.Head != null)
                {
                    if (Convert.ToInt32(List1.Head.Data) <= 0)
                    {
                        return false;
                    }
                    List1.Head = List1.Head.Next;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(MyList<T> List1)
        {
            if (List1.count != 0)
            {
                while (List1.Head != null)
                {
                    if (Convert.ToInt32(List1.Head.Data) <= 0)
                    {
                        return true;
                    }
                    List1.Head = List1.Head.Next;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
