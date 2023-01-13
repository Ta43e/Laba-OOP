using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA15
{
    internal class Exercise1
    {
        public static List<int> Ex1(int num)
        {

            var ovner = Task<List<int>>.Factory.StartNew(() =>
            {
            Console.WriteLine("Начало работы алгоритма “Решето Эратосфена”");
            var inner = Task<List<int>>.Factory.StartNew(() =>
                    {
                        var result = new List<int>();
                        for (var i = 2; i < num; i++)
                        {
                            result.Add(i);
                        }

                        for (var i = 0; i < result.Count; i++)
                        {
                            for (var j = 2; j < num; j++)
                            {
                                //удаляем кратные числа из списка
                                result.Remove(result[i] * j);
                            }
                        }
                        foreach (var item in result)
                        {
                            Console.WriteLine($"Элемент {item}");
                        }
                        return result;
                    }, TaskCreationOptions.AttachedToParent);

                return inner.Result;
            });
            ovner.Wait();
            Console.WriteLine("Конец “Решето Эратосфена”");
            return ovner.Result;
        }
    }
}
