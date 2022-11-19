using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA12
{
    public static class StreamReaderLog
    {
        public static void Reader()
        {
            var output = new StringBuilder();
            using (StreamReader stream = new StreamReader(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\xxxlogfile.txt"))
            {
                string? textline = null;
                var isActual = false;
                while (!stream.EndOfStream)
                {
                    isActual = false;
                    if (textline == null)
                    {
                        textline = stream.ReadLine();
                        if (textline != "" && DateTime.Parse(textline).Day == DateTime.Now.Day)
                        {
                            isActual = true;
                            output.AppendFormat(textline);
                        }
                    }
                    else
                    {
                        if (textline.Contains("END"))
                        {
                            break;
                        }
                        if (textline != "" && DateTime.Parse(textline).Day == DateTime.Now.Day)
                        {
                            isActual = true;
                            output.AppendFormat(textline);
                        }
                    }
                    textline = stream.ReadLine();
                    while(isActual)
                    {
                        if (textline.Contains("2022") && !textline.Contains("создания"))
                        {
                            if (textline != "" && DateTime.Parse(textline).Day == DateTime.Now.Day)
                            {
                                isActual = false;
                                output.AppendFormat(textline);
                            }
                        }
                        if (!isActual)
                        {
                            break;
                        }
                        if (textline.Contains("END"))
                        {
                            break;
                        }
                        output.AppendFormat(textline);
                        textline = stream.ReadLine();
                    }

                }
            }
            using (var readerNew = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA12\KODlogfile.txt"))
            {
                readerNew.WriteLine(output.ToString());
            }
        }
    }
}