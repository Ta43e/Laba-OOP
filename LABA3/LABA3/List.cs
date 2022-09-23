using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nodes;
namespace LABA3
{

    public class MyList
    {
        public class Production
        {
            private int Id;
            private string Organization { get; set; }
            public Production (int Id, string Organization)
            {
                this.Id = Id;
                this.Organization = Organization;
            }
        }

        public class Developer
        {
            private int Id;
            private string UserId { get; set; }
            private string Otdel { get; set; }
            public Developer(int Id, string UserId, string Otdel )
            {
                this.Id = Id;
                this.UserId = UserId;
                this.Otdel = Otdel;
            }
        }

        private Node head;
        public Node Head {
            get { return head; }
            set { head = value; }
        }
        private Node tail;
        public Node Tail {
            get { return tail; }
            set { tail = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
        }

        public void Add(string data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }

            else
            {
                tail.Next = node;
            }
            tail = node;
            count++;
        }
        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }
        public static MyList operator +(MyList List1, MyList List2)
        {
            List1.tail.Next = List2.head;
            List1.tail = List2.tail;
            List1.count += List2.count;
            return List1;
        }
        public static MyList operator --(MyList List1)
        {

            List1.head = List1.head.Next;
            List1.count--;
            return List1;
        }
        public static bool operator ==(MyList List1, MyList List2)
        {
            if (List1.count == List2.count)
            {
                while (List1.head != null)
                {
                    int tmp =  String.Compare(List1.head.Data, List2.head.Data); 
                    if (tmp != 0)
                    {
                        return false;
                    }
                    List1.head = List1.head.Next;
                    List2.head = List2.head.Next;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(MyList List1, MyList List2)
        {
            if (List1.count != List2.count)
            {
                while (List1.head != null)
                {
                    int tmp = String.Compare(List1.head.Data, List2.head.Data);
                    if (tmp != 0)
                    {
                        return true;
                    }
                    List1.head = List1.head.Next;
                    List2.head = List2.head.Next;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator true(MyList List1)
        {
            if (List1.count != 0)
            {
                while (List1.head != null)
                {
                    if (Convert.ToInt32(List1.head.Data) <= 0)
                    {
                        return false;
                    }
                    List1.head = List1.head.Next;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(MyList List1)
        {
            if (List1.count != 0)
            {
                while (List1.head != null)
                {
                    if (Convert.ToInt32(List1.head.Data) <= 0)
                    {
                        return true;
                    }
                    List1.head = List1.head.Next;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public string LastNode()
        {

            return this.tail.Data;
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
                this.head = this.head.Next;
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
                while(true)
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
            Node previousNode = head;
            for (int i = 0; i < pos - 1; i++)
            {
                previousNode = previousNode.Next;
            }
            return previousNode;
        }
        
        public string Sort(MyList List1)
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
                            int tmp = Convert.ToInt32(List1.Head.Data);
                            List1.Head.Data = List1.Head.Next.Data;
                            List1.Head.Next.Data = Convert.ToString(tmp);
                        }
                    }
                    List1.Head = List1.Head.Next;
                }
            }
            List1.Head = tmps;
            return List1.Head.Data;
        }

    }
}
