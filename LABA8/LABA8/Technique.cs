using System;

namespace LABA8
{
    public delegate void Turn();
    public delegate void Upgrade(int val);
    public class Technique
    {
        public string Name;
        public int maxTension;
        public bool includedChek;
        public event Turn turn;
        public event Turn turn_off;
        public event Upgrade upgrade;
        public Technique(string name, int maxTension)
        {
            Name = name;
            this.maxTension = maxTension;
            this.includedChek = includedChek;
        }
        public override string ToString()
        {
            return GetType().Name + ", Name: " + Name + ", maxTension: " +
                maxTension + ", состояние: " + includedChek;
        }
        public void Turn_on(int Tension)
        {
            if (Tension > maxTension)
            {
                Turn_off();
                throw new Exception("Недопустимое напряжение");
            }
            else
            {
               if (turn != null) turn();
                includedChek = true;
            }
        }
        public void Turn_off()
        {
            includedChek = false;
            if(turn_off != null) turn_off();

        }
        public void Upgrade(int value)
        {
            upgrade(value);
            maxTension = value;
        }
    }
}
