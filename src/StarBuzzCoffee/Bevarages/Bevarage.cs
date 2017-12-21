namespace StarBuzzCoffee.Bevarages
{
    public abstract class Bevarage
    {
        public string Description = "Unknown Bevarage";

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
