using System;

namespace LABA8
{
    public class Test
    {
        public static void Main()
        {
            try
            {
                Technique technique = new Technique("Oleg", 12);
                technique.turn += Boss.Turn_On;
                technique.turn_off += Boss.Turn_Off;
                technique.upgrade += Boss.Update;
                technique.Turn_on(11);
                technique.Upgrade(100);
                string str = "Хи-хи-хи-ха, че,     зак!ибер#булили тебя, да, ну я не знаю, выключи компбютер, всё, иди н        аф;;иг";
                strEditor.str = str;
                Action stringEdit = () => strEditor.Remove();
                stringEdit += () => strEditor.ToUpperCase();
                stringEdit += () => strEditor.ToLowerCase();
                stringEdit += () => strEditor.RemoveSpaces();
                stringEdit += () => strEditor.AddQuestion();
                stringEdit?.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
