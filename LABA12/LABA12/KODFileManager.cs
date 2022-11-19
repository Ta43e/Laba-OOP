using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA12
{
    internal static class KODFileManager
    {
        public static void FileManager(string driverName)
        {
            Directory.CreateDirectory(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspect");
            File.Create(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspect\KODdirinfo.txt").Close();
            FileInfo fileInfo = new FileInfo(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspect\KODdirinfo.txt");
            var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driverName);
            using (StreamWriter file = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspect\KODdirinfo.txt"))
            {
                file.WriteLine("Список папок:");
                KODLog.Log("KODFileManager", $"============================================================ \n Работа с методом KODInspect \n"); 
                foreach (var s in currentDrive.RootDirectory.GetDirectories())
                {
                    file.WriteLine(s);
                }
                file.WriteLine("Список файлов:");
                foreach (var f in currentDrive.RootDirectory.GetFiles())
                {
                    file.WriteLine(f);
                }
            }
            
            fileInfo.CopyTo(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspect\KODdirinfoNEW.txt", true);
            File.Delete(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspect\KODdirinfo.txt");
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
        public static void NevKODFiles(string DirName, string extensions)
        {
            Directory.CreateDirectory(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles");
            foreach (var f in Directory.GetFiles(DirName, "*.*", SearchOption.TopDirectoryOnly))
                if (extensions == Path.GetExtension(f))
                    File.Copy(f, @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles\" + Path.GetFileName(f), true);
            if (Directory.Exists(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspectNew"))
            {
                Directory.Delete(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspectNew", true);
                Directory.Move(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles", @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspectNew");
            }
            else
            {
                Directory.Move(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles", @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODInspectNew");
            }
            KODLog.Log("KODFileManager", $"============================================================ \n Работа с методом NewKODFiles");
        }
        public static void ZIPFiles(string DirName, string extensions)
        {
            KODLog.Log("KODFileManager", $"============================================================ \n Работа с методом ZIPFiles");
            Directory.CreateDirectory(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles");
            foreach (var f in Directory.GetFiles(DirName, "*.*", SearchOption.TopDirectoryOnly))
                if (extensions == Path.GetExtension(f))
                    File.Copy(f, @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles\" + Path.GetFileName(f), true);
            string directoriPatch = @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12";
            var newDirectoriPatch = Path.Combine(directoriPatch, "pack.zip");
            if (Directory.Exists(newDirectoriPatch)) Directory.Delete(newDirectoriPatch, true);
            ZipFile.CreateFromDirectory(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODFiles", newDirectoriPatch);
            string targetFolder = @"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODDearhif";
            if (Directory.Exists(targetFolder))
                Directory.Delete(targetFolder, true);
            Directory.CreateDirectory(targetFolder);
            ZipFile.ExtractToDirectory(newDirectoriPatch, targetFolder);
            KODLog.ENDLOG();
        }

    }
}