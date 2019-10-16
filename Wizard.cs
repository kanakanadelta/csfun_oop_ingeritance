namespace Inheritance
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Health = 50;
            Intelligence = 25;
        }

        // Methods
        public override int Attack(Human target)
        {
            int dmg = Intelligence*5;
            target.Health -= (dmg);
            System.Console.WriteLine($"{Name} attacked {target.Name} and heals themselves for {dmg}!");
            return target.Health;
        }

        public int Heal(Human target)
        {
            int hp = Intelligence * 10;
            target.Health -= (hp);
            System.Console.WriteLine($"{Name} heals {target.Name} with {hp}!");
            return target.Health;
        }
    }
}