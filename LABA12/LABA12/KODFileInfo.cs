using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LABA12
{
    internal static class KODFileInfo
    {
        public static string path = @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\xxxlogfile.txt";
        public static void FileInfo()
        {
            FileInfo file = new FileInfo(path);
            Console.WriteLine("\n==========Информация об файле==========");
            Console.WriteLine($"Полный путь к файлу {file.DirectoryName}");
            Console.WriteLine($"Имя файла: {file.Name}, размер файла: {file.Length}, расширение файла: {file.Extension}");
            Console.WriteLine($"Дата создания  файла: {file.CreationTime}");
            Console.WriteLine("========================================");
            KODLog.Log("KODFileInfo", $" ============================================================ \n Полный путь к файлу {file.DirectoryName} \n Имя файла: {file.Name}, размер файла: {file.Length}, расширение файла: {file.Extension} \n Дата создания  файла: {file.CreationTime}");
        }
    }
}
