using StarBuzzCoffee.Bevarages;

namespace StarBuzzCoffee.Condiments
{
    public class Whip : CondimentsDecorator
    {
        private readonly Bevarage _bevarage;

        public Whip(Bevarage bevarage)
        {
            _bevarage = bevarage;
        }

        public override string GetDescription()
        {
            return $"{_bevarage.GetDescription()}, Whip(+R0.10)";
        }

        public override double Cost()
        {
            return .10 + _bevarage.Cost();
        }
    }
}
