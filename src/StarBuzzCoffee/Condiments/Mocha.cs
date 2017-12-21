using StarBuzzCoffee.Bevarages;

namespace StarBuzzCoffee.Condiments
{
    public class Mocha : CondimentsDecorator
    {
        private readonly Bevarage _bevarage;

        public Mocha(Bevarage bevarage)
        {
            _bevarage = bevarage;
        }

        public override string GetDescription()
        {
            return $"{_bevarage.GetDescription()}, Mocha(+R0.20)";
        }

        public override double Cost()
        {
            return .20 + _bevarage.Cost();
        }
    }
}
