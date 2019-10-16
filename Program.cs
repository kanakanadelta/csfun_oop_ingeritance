using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human guy = new Human("Guy");
            Wizard wiz = new Wizard("Wiz");
            Ninja ninja = new Ninja("Ninja");
            Samurai sam = new Samurai("Sam");


            wiz.Attack(guy);
            wiz.Heal(guy);
            wiz.Heal(guy);
            wiz.Heal(guy);

            ninja.Attack(guy);
            ninja.Attack(guy);
            ninja.Attack(guy);
            ninja.Attack(guy);
            ninja.Attack(guy);

            sam.Attack(wiz);
            sam.Attack(wiz);

        }
    }
}
