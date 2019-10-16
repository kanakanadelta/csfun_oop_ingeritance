using System;

namespace Inheritance
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }

        // methods
        public override int Attack(Human target)
        {
            if(target.Health < 50)
            {
                target.Health = 0;
                System.Console.WriteLine($"{target.Name} died.");
                return target.Health;
            }
            else
            {
                return base.Attack(target);
            }
        }

        public void Meditate()
        {
            System.Console.WriteLine($"{Name} meditates...");
            if (Health < 200)
                Health = 200;
        }
    }
}