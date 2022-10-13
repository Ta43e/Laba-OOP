using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LABA6
{
    public class main
    {
        public static void Main(string[] args)
        {
            // ------ Макрос Assert ------ 
            int index;
            index = -40;
            Debug.Assert(index > -1, "Error, gabela");
           Flowers flowers3 = new Flowers(12, "BSTU", "Rose", "Post By", "Red", 12);
            ThrowException1(flowers3);
            static void ThrowException1(Flowers flowers3)
            {
                try
                {
                    flowers3.TestProbros(12);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            try
            {
                ThrowException1(flowers3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception 1:");
                Console.WriteLine(e.StackTrace);
            }
            try
            {
                Goods flowers1 = new Flowers(12, "BSTU", "Rose", "Post By", "Red", 0);
                Console.WriteLine(flowers1.ToString());
            }
            catch (ErrorInMass e)
            {
                Console.WriteLine("Error 1");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ExceptionClass);
                Console.WriteLine(e.Mass);
            }
            try
            {
                Goods flowers2 = new Flowers(0, "BSTU", "Rose", "Post By", "Red", 10);
                Console.WriteLine(flowers2.ToString());
            }
            catch (ErrorInCost e)
            {
                Console.WriteLine("Error 2");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ExceptionClass);
                Console.WriteLine(e.Cost);
            }
            try
            {
                Goods flowers2 = new Flowers(100000, "BSTU", "Rose", "Post By", "Red", 10);
                Console.WriteLine(flowers2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error 3");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Всё норм");
            }
        }
    }
}
