using System;
using StarBuzzCoffee.Bevarages;
using StarBuzzCoffee.Condiments;

namespace StarBuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Bevarage bevarage = new Espresso();
            Console.WriteLine($"{bevarage.GetDescription()}: R{bevarage.Cost()}");

            Bevarage bevarage2 = new DarkRoast();
            bevarage2 = new Mocha(bevarage2);
            bevarage2 = new Mocha(bevarage2);
            bevarage2 = new Whip(bevarage2);
            Console.WriteLine($"{bevarage2.GetDescription()}: R{bevarage2.Cost()}");

            Bevarage bevarage3 = new HouseBlend();
            bevarage3 = new Soy(bevarage3);
            bevarage3 = new Mocha(bevarage3);
            bevarage3 = new Whip(bevarage3);
            Console.WriteLine($"{bevarage3.GetDescription()}: R{bevarage3.Cost()}");

            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}
