using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Inventory
{
    public class Item
    {
        
        public string NameItem { get; set; }
        //فعلا اینو نمیزارم
        //public int Defend { get; set; }

        public Item(string name)
        {
            NameItem = name;
        }


    }
}
