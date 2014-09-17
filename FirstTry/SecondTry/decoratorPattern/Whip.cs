namespace SecondTry.decoratorPattern
{
    public class Whip : Decorator
    {
        public Beverage Beverage;

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override double Cost()
        {
            return 0.15 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return "Whiped " + Beverage.GetDescription();
        }
    }
}