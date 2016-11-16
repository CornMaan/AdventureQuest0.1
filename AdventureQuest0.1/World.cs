using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    class World
    {
        Player player = new Player();
        potion po = new potion();
        WorldGenerator generator = new WorldGenerator();

        public World()
        {
            player.CurrentRoom = generator.GetRoom("Spawn");
        }
        public void HandleInput()
        {
            bool isRunning = true;
            while (isRunning)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("exit") || input.ToLower().Equals("e"))
                {
                    isRunning = false;
                }
                else
                {
                    HandleMovement();
                }
            }
        }
        public void HandleMovement()
        {
            char input = Console.ReadKey(true).KeyChar;
            switch (input)
            {
                case 'w':
                    player.CurrentRoom = player.CurrentRoom.north;
                    break;
                case 's':
                    player.CurrentRoom = player.CurrentRoom.south;
                    break;
                case 'd':
                    player.CurrentRoom = player.CurrentRoom.east;
                    break;
                case 'a':
                    player.CurrentRoom = player.CurrentRoom.west;
                    break;
                case 'p':
                    po.takepotion(player);
                    break;
            }
        }
    }
}