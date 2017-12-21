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
            Print(bevarage);

            Bevarage bevarage2 = new DarkRoast();
            bevarage2 = new Mocha(bevarage2);
            bevarage2 = new Mocha(bevarage2);
            bevarage2 = new Whip(bevarage2);
            Print(bevarage2);

            Bevarage bevarage3 = new HouseBlend();
            bevarage3 = new Soy(bevarage3);
            bevarage3 = new Mocha(bevarage3);
            bevarage3 = new Whip(bevarage3);
            Print(bevarage3);

            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }

        private static void Print(Bevarage bevarageToPrint)
        {
            Console.WriteLine($"{bevarageToPrint.GetDescription()}: R{bevarageToPrint.Cost()}");
        }
    }
}
