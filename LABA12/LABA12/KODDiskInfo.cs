using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA12
{
    internal static class KODDiskInfo
    {
        public static void FreeDiskSpace()
        {
            Console.WriteLine("===================Информация об дисках=====================");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                if (item.Name.Contains("F:") )
                {
                    continue;
                }
                Console.WriteLine($"Свободное место на диске {item.Name}: {item.TotalFreeSpace / 1048576}  Mбайт");
                Console.WriteLine($"Файловая система: {item.DriveFormat}");
                Console.WriteLine($"Общий объем: {item.TotalSize / 1048576} Mбайт");
                Console.WriteLine($"Метка тома: {item.VolumeLabel}");
                Console.WriteLine("--------------------------------------------------------------------------------");
                KODLog.Log("KODDiskInfo", $"============================================================ \n Свободное место на диске {item.Name}: {item.TotalFreeSpace / 1048576}  Mбайт \n Файловая система: {item.DriveFormat} \n Общий объем: {item.TotalSize / 1048576} Mбайт \n Метка тома: {item.VolumeLabel} \n --------------------------------------------------------------------------------");
            }
            Console.WriteLine("============================================================");
        }
    }
}
