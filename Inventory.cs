using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZuulCS
{
    class Inventory
    {
        private Dictionary<string, Item> items;
        private float maxWeight;
        private float currentWeight;

        internal Dictionary<string, Item> Items { get => items; }

        public Inventory()
        {
            items = new Dictionary<string, Item>();
            currentWeight = 0;
            maxWeight = 10;
        }
        public void removeItem(string b)
        {
            items.Remove(b);
        }
        public float calculateWeight()
        {
            currentWeight = 0;
            foreach (Item i in items.Values)
            {
                currentWeight += i.weight;
            }
            return maxWeight;
        }

        public void AddItem(Item a)
        {
            if (currentWeight > maxWeight)
            {
                Console.WriteLine("Inventory is full!");
            }
            else
            {
                items.Add(a.itemName, a);
                currentWeight += a.weight;
            }
        }
    }
    
}
