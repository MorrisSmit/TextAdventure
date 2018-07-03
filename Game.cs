using System;

namespace ZuulCS
{
	public class Game
	{
		private Parser parser;
        private Player player;

		public Game ()
		{
			parser = new Parser();
            player = new Player();
            createRooms();
        }

		


		/**
	     *  Main play routine.  Loops until end of play.
	     */
		public void play()
		{
			printWelcome();

			// Enter the main command loop.  Here we repeatedly read commands and
			// execute them until the game is over.
			bool finished = false;
            while (!finished && player.IsAlive()) {
				Command command = parser.getCommand();
				finished = processCommand(command);
			}
			Console.WriteLine("Thank you for playing.");
		}
        public void createRooms()
        {
            Room outside, theatre, pub, lab, office, secretroom;

            // create the rooms
            outside = new Room("outside the main entrance of the university");
            theatre = new Room("in a lecture theatre");
            pub = new Room("in the campus pub");
            lab = new Room("in a computing lab");
            office = new Room("in the computing admin office");
            secretroom = new Room("in a secret room, there is ");

            // initialise room exits
            outside.setExit("east", theatre);
            outside.setExit("south", lab);
            outside.setExit("west", pub);

            theatre.setExit("west", outside);

            pub.setExit("east", outside);

            lab.setExit("north", outside);
            lab.setExit("east", office);

            office.setExit("west", lab);
            office.setExit("up", secretroom);

            secretroom.setExit("down", office);

            player.CurrentRoom = outside;  // start game outside


            //lab.inventory.add();
        }

        /**
	     * Print out the opening message for the player.
	     */
        private void printWelcome()
		{
			Console.WriteLine();
			Console.WriteLine("Welcome to Zuul!");
			Console.WriteLine("Zuul is a new, incredibly boring adventure game.");
			Console.WriteLine("Type 'help' if you need help.");
			Console.WriteLine();
			Console.WriteLine(player.CurrentRoom.getLongDescription());
		}

		/**
	     * Given a command, process (that is: execute) the command.
	     * If this command ends the game, true is returned, otherwise false is
	     * returned.
	     */
		private bool processCommand(Command command)
		{
			bool wantToQuit = false;

			if(command.isUnknown()) {
				Console.WriteLine("I don't know what you mean...");
				return false;
			}

			string commandWord = command.getCommandWord();
			switch (commandWord) {
				case "help":
					printHelp();
					break;
				case "go":
					player.goRoom(command);
					break;
				case "quit":
					wantToQuit = true;
					break;
                case "look":
                    Console.WriteLine(player.CurrentRoom.getLongDescription());
                    break;
			}

			return wantToQuit;
		}

		private void printHelp()
		{
			Console.WriteLine("You are lost. You are alone.");
			Console.WriteLine("You wander around at the university.");
			Console.WriteLine();
			Console.WriteLine("Your command words are:");
			parser.showCommands();
		}
		

	}
}
