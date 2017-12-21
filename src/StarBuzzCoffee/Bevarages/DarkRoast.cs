namespace StarBuzzCoffee.Bevarages
{
    public class DarkRoast : Bevarage
    {
        public override string GetDescription()
        {
            return "Dark Roast(R0.99)";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
