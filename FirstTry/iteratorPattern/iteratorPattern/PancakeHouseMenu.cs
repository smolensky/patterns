using System.Collections;

namespace iteratorPattern.iteratorPattern
{
    class PancakeHouseMenu
    {
        private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();

            AddItem("Pancake breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry pancakes", "Pancakes with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choise of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool veggie, double price)
        {
            var menuItem = new MenuItem(name, description, veggie, price);
            _menuItems.Add(menuItem);
        }

        public ArrayList GetMenuItems()
        {
            return _menuItems;
        }
    }
}
