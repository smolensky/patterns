using System;

namespace iteratorPattern.iteratorPattern
{
    class DinerMenu
    {
        const int MaxItem = 6;
        private int _numberOfItems;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItem];

            AddItem("Veggie BLT", "(Fakin') Bacon with letucce&tomato on whole wheat", true, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("HotDog", "A hotdog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool veggie, double price)
        {
            var menuItem = new MenuItem(name, description, veggie, price);
            if (_numberOfItems >= MaxItem)
                Console.WriteLine("Menu is full.");
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }
    }
}