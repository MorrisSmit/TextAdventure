using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZuulCS
{
    class Inventory
    {
        Dictionary<string, Item> inventory;
        private float maxWeight;

        public Inventory()
        {
            maxWeight = 10;
        }

        public void AddItem(Item a)
        {
            inventory.Add(a.itemName, a);
        }
    }
    
}
