using StarBuzzCoffee.Bevarages;

namespace StarBuzzCoffee.Condiments
{
    public class Soy : CondimentsDecorator
    {
        private readonly Bevarage _bevarage;

        public Soy(Bevarage bevarage)
        {
            _bevarage = bevarage;
        }

        public override string GetDescription()
        {
            return $"{_bevarage.GetDescription()}, Soy(+R0.15)";
        }

        public override double Cost()
        {
            return .15 + _bevarage.Cost();
        }
    }
}
