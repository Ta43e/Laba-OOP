using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LABA9
{
    public static class obrabotchik
    {
        public static void Obr(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Image image)
                        Console.WriteLine($"Добавлен новый элемент: {image.ToString()}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Image oldImage)
                        Console.WriteLine($"Удален элемент: {oldImage.ToString()}");
                    break;
                default: Console.WriteLine("Операция не найдена!");
                    break;
            }
        }
    }
}
