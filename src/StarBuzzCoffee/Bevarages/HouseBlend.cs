namespace StarBuzzCoffee.Bevarages
{
    public class HouseBlend : Bevarage
    {
        public override string GetDescription()
        {
            return "House Blend(R0.89)";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
