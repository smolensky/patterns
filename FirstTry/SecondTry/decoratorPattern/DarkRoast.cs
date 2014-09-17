namespace SecondTry.decoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override double Cost()
        {
            return 0.99;
        }

        public override string GetDescription()
        {
            return Description = "Dark Roast";
        }
    }
}