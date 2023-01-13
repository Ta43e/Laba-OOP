using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LABA15
{
    internal class Exercise2
    {
        public static List<int> Ex2(int num)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прерван");
                throw new Exception("Операция прервана");     //  выходим из метода и тем самым завершаем задачу
            }
            var ovner = Task<List<int>>.Factory.StartNew(() =>
            {
                Console.WriteLine("Начало работы алгоритма “Решето Эратосфена”");
                var inner = Task<List<int>>.Factory.StartNew(() =>
                {
                    var result = new List<int>();
                    for (var i = 2; i < num; i++)
                    {
                        result.Add(i);
                        Thread.Sleep(10);
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
                });

                return inner.Result;
            });
            cancelTokenSource.Cancel();
            Thread.Sleep(1000);
            //  проверяем статус задачи
            Console.WriteLine($"Task Status: {ovner.Status}");
            if (cancelTokenSource.IsCancellationRequested)
            {
                cancelTokenSource.Dispose(); // освобождаем ресурсы
                throw new Exception("========Операция прервана========");
            }

            Console.WriteLine("Конец “Решето Эратосфена” \n ================");
            
            return ovner.Result;
        }
    }
}
