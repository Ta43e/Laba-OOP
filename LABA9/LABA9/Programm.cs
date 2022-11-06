using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9
{
    delegate void PrintQueue(Queue<int> que);
    delegate void PrintLinked(LinkedList<int> que);
    delegate void Copy(Queue<int> que, LinkedList<int> list);
    delegate void Delete(LinkedList<int> list, int index, int n);
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------");
            Image img1 = new Image("Romaschki", "Oleg");
            Image img2 = new Image("Dom", "Andrei");
            Image img3 = new Image("Reka", "Anton");
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
            Console.WriteLine("------------------Вывод новосозданной коллекции------------------");
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);    
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            PrintLinked printList = delegate (LinkedList<int> que) // анонимная функция для выводы LinkedList
            {
                LinkedListNode<int> node = list.First;
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
            };
            printList(list);
            Console.WriteLine("--------------Удаление n элементов----------------------");
            Delete delete = delegate (LinkedList<int> list, int index, int n)
            {
                if (n >= list.Count || n + index >= list.Count || n <= 0 || index < 0)
                {
                    Console.WriteLine("Ошибка, невозможно удалить данные элементы");
                }
                else
                {
                    LinkedListNode<int> node = list.First;
                    int tmp = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i >= index || tmp <= n)
                        {
                            var nodeN = node.Next;
                            list.Remove(node.Value);
                            node = nodeN;
                            tmp++;
                            continue;
                        }
                        node = node.Next;
                    }
                }
            };

            delete(list, 1, 2);
            printList(list);
            Console.WriteLine("----------------Первая колекция с различными добавлениями---------------------");
            list.AddFirst(60);
            list.AddLast(70);
            printList(list);
            Console.WriteLine("--------------Вторая коллекция, в которой содержаться элементы первой коллекции----------------------");
            Queue<int> people = new Queue<int>();
            Copy copy = delegate (Queue<int> que, LinkedList<int> list)
            {
                LinkedListNode<int> node = list.First;
                while (node != null)
                {
                    people.Enqueue(node.Value);
                    node = node.Next;
                }
            };
            copy(people, list);
            PrintQueue Print = delegate (Queue<int> que)
            {
                while (people.Count > 0)
                {
                    var patient = people.Dequeue();
                    Console.WriteLine(patient);
                }
            };

            Print(people);    // анонимный метод
            Console.WriteLine("--------------------ObservableCollection----------------");
            ObservableCollection<Image> observableCollection = new ObservableCollection<Image>();
            foreach (var item in observableCollection)
            {
                Console.WriteLine(item.ToString());
            }
            observableCollection.CollectionChanged += obrabotchik.Obr;
            observableCollection.Add(img1);
            observableCollection.Add(img2);
            observableCollection.Add(img3);
            observableCollection.Remove(img2);
            Console.WriteLine("--------------------Вывод----------------");
            foreach (var item in observableCollection)
            {
                Console.WriteLine(item.ToString());
            }

        }

    }
}
