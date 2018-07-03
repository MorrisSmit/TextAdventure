using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZuulCS
{
    class Player
    {
        private Inventory inventory;
        private Room currentRoom;
        private int health;
        public bool isBleeding;

        internal Room CurrentRoom { get => currentRoom; set => currentRoom = value; }


        public Player()
        {
            inventory = new Inventory();
            this.health = 100;
            IsAlive();
            isBleeding = false;
        }

        

        private int Damage (int amount)
        {
            this.health -= amount;
            IsAlive();
            return this.health;
        }

        public void Heal(int amount)
        {
            health += amount;
        }
        

        public bool IsAlive()
        {
            if (health < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Bleed()
        {
            if (isBleeding)
            {
                health -= 10;
            }
        }

        public void goRoom(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word, we don't know where to go...
                Console.WriteLine("Go where?");
                return;
            }

            string direction = command.getSecondWord();

            // Try to leave current room.
            Room nextRoom = this.CurrentRoom.getExit(direction);

            if (nextRoom == null)
            {
                Console.WriteLine("There is no door to " + direction + "!");
            }
            else
            {
                this.CurrentRoom = nextRoom;
                Console.WriteLine(this.CurrentRoom.getLongDescription());
                Bleed();
            }
        }

    }
}
