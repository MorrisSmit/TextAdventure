using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZuulCS
{
    class Player
    {
        private Room currentRoom;
        private int health;

        internal Room CurrentRoom { get => currentRoom; set => currentRoom = value; }


        public Player()
        {
            this.health = 0;
            IsAlive();
        }

        

        private int Damage (int amount)
        {
            this.health -= amount;
            IsAlive();
            return this.health;
        }

        private int Heal(int amount)
        {
            this.health += amount;
            return this.health;
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
                this.Damage(2);
            }
        }

    }
}
