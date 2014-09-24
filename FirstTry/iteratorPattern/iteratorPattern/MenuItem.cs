namespace iteratorPattern.iteratorPattern
{
    class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _veggie;
        private readonly double _price;

        public MenuItem(string name, string description, bool veggie, double price)
        {
            _name = name;
            _description = description;
            _veggie = veggie;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool GetVeggie()
        {
            return _veggie;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}