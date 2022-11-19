using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA12
{
    internal class Programm
    {
        public static void Main()
        {
            KODDiskInfo.FreeDiskSpace();
            KODFileInfo.FileInfo();
            KODDirInfo.DirInfo();
            KODFileManager.FileManager("D:\\");
            KODFileManager.NevKODFiles(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\Test", ".txt");
            KODFileManager.ZIPFiles(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\Test", ".txt");
            StreamReaderLog.Reader();
        }
    }
}
