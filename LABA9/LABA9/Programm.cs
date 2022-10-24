using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9
{
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------");
            Image img1 = new Image("Romaschki", "Oleg");
            Image img2 = new Image("Dom", "Andrei");
            Image img3 = new Image("Reka", "Vlad");
            Collection<Image> images = new Collection<Image>();
            images.Add(img1);
            images.Add(img2);
            images.Add(img3);
            images.Print();
            Console.WriteLine("---------------------------------------");
            images.Remove(img1);
            images.Print();
            Console.WriteLine("---------------------------------------");
            images.FindItem(img3);
            Console.WriteLine("---------------------------------------");
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);    
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            LinkedListNode<int> node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next; 
            }
            Console.WriteLine("---------------------------------------");
            for (int i = 1; i < list.Count - 1; i++)
            {
                list.Remove(i);
            }
           node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine("---------------------------------------");
            list.AddFirst(60);
            list.AddLast(70);
        }

    }
}
