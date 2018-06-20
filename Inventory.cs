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
        private float currentWeight;

        public Inventory()
        {
            currentWeight = 0;
            maxWeight = 10;
        }
        public float calculateWeight()
        {
            currentWeight = 0;
            foreach (Item i in inventory.Values)
            {
                currentWeight += i.weight;
            }
            return maxWeight;
        }

        public void AddItem(Item a)
        {
            inventory.Add(a.itemName, a);
            currentWeight += a.weight;
        }
    }
    
}
