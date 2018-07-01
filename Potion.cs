using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuulCS
{
    class Potion : Item
    {
        private int HealAmount;

        public Potion()
        {
            HealAmount = 25;
            _weight = 1;
            _itemName = "Potion";
            description = "A potion, drink it and see what happens.";
        }
        public override void Use()
        {
            Player.Heal(HealAmount);
        }
    }
}
