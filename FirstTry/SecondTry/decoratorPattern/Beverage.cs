namespace SecondTry.decoratorPattern
{
    public abstract class Beverage
    {
        public string Description = "No description";

        public abstract double Cost();

        public abstract string GetDescription();
    }
}
