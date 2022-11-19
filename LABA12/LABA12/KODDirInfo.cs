using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA12
{
    internal static class KODDirInfo
    {
        public static string path = @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP";
        public static void DirInfo()
        {
            Console.WriteLine("\n===================Информация об директиве==========================");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine($"Информация об директиве: {directoryInfo.Name}");
            Console.WriteLine($"Кол-во файлов: {directoryInfo.GetFiles().Length}");
            Console.WriteLine($"Кол-во директив: {directoryInfo.GetDirectories().Length}");
            Console.WriteLine($"Время создания директивы: {directoryInfo.CreationTime}");
            Console.WriteLine($"Родительские директивы: {directoryInfo.Parent}");
            Console.WriteLine("==================================================");
            KODLog.Log("KODDirInfo", $" ============================================================ \n Информация об директиве: {directoryInfo.Name} \n Кол-во файлов: {directoryInfo.GetFiles().Length} \n Кол-во директив: {directoryInfo.GetDirectories().Length} \n Время создания директивы: { directoryInfo.CreationTime} \n Родительские директивы: {directoryInfo.Parent}");

        }
    }
}
