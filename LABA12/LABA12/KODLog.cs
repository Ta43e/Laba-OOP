using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA12
{
    internal static class KODLog
    {
        public static void Log(string NameFile, string Messege)
        {
            using (StreamWriter _writer = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\xxxlogfile.txt", true))
            {
                _writer.WriteLine(DateTime.Now.ToString());
                _writer.WriteLine(Messege);
                _writer.WriteLine(NameFile);
            }

        }
        public static void ENDLOG()
        {
            using (StreamWriter _writer = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\xxxlogfile.txt", true))
            {
                _writer.WriteLine("END");
            }
        }

    }
}
