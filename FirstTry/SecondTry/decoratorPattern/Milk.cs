namespace SecondTry.decoratorPattern
{
    public class Milk : Decorator
    {
        public Beverage Beverage;

        public Milk(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override double Cost()
        {
            return 0.2 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return "Milked " + Beverage.GetDescription();
        }
    }
}