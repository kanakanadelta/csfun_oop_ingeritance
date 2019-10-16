using System;

namespace Inheritance
{
    public class Ninja : Human
    {
        public Ninja(string name) : base (name)
        {
            Name = name;
            Dexterity = 175;
        }

        //methods

        public override int Attack(Human target)
        {

            Random r = new Random();
            int extraDmg = (r.Next(0,5) < 1 ? 10 : 0);
            int dmg = Dexterity*5;
            
            target.Health -= (dmg + extraDmg);
            System.Console.WriteLine($"{Name} attacked {target.Name} and for {dmg} with {extraDmg} extra damage!");
            return target.Health;
        }

        public int Steal(Human target)
        {
            int dmg = 5;
            target.Health -= (dmg);
            System.Console.WriteLine($"{Name} steals from {target.Name} and heals themselves for {dmg}!");
            return target.Health;
        }
    }
}