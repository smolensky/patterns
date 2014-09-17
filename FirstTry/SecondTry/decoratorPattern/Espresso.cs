namespace SecondTry.decoratorPattern
{
    public class Espresso : Beverage
    {
        public override double Cost()
        {
            return 1.99;
        }

        public override string GetDescription()
        {
            return Description = "Espresso";
        }
    }
}