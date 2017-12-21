namespace StarBuzzCoffee.Bevarages
{
    public class Decaf : Bevarage
    {
        public override string GetDescription()
        {
            return "Decaf(R1.05)";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
