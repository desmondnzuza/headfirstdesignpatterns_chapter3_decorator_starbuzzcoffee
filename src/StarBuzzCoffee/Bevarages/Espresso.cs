namespace StarBuzzCoffee.Bevarages
{
    public class Espresso : Bevarage
    {
        public override string GetDescription()
        {
            return "Espresso(R1.99)";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
