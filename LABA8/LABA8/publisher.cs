using System;

namespace LABA8
{
    public static class Boss
    {
        public static void Turn_On()
        {
            Console.WriteLine("Техника работает");
        } 
        public static void Turn_Off()
        {
            Console.WriteLine("Техника не работает");
        }
        public static void Update(int value)
        {
            Console.WriteLine("Новое напряжение: " + value);
        }
    }
}
