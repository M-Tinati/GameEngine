using GameEngine.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest.Menus
{
    public class ItemMenu
    {
        List<Item> item = new List<Item>();
        public void ItemMenus()
        {
            item.Add(new Item("Iron Sword"));
            item.Add(new Item("Health Potion"));
            item.Add(new Item("Wooden Shield"));
        }
        public void InventoyesInformation()
        {
            foreach (Item i in item)
            {
                Console.WriteLine($"{i.NameItem}");
            }
        }
    }
}
