using StarBuzzCoffee.Bevarages;

namespace StarBuzzCoffee.Condiments
{
    public class SteamedMilk : CondimentsDecorator
    {
        private readonly Bevarage _bevarage;

        public SteamedMilk(Bevarage bevarage)
        {
            _bevarage = bevarage;
        }

        public override string GetDescription()
        {
            return $"{_bevarage.GetDescription()}, SteamedMilk(+R0.10)";
        }

        public override double Cost()
        {
            return .10 + _bevarage.Cost();
        }
    }
}
