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
        PlayerHandler playerhandle = new PlayerHandler();
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
                    playerhandle.MoveUp(player, generator.GetRoom(player.CurrentRoom.ToString()));
                    break;
                case 's':
                    playerhandle.MoveDown(player, generator.GetRoom(player.CurrentRoom.ToString()));
                    break;
                case 'd':
                    playerhandle.MoveRight(player, generator.GetRoom(player.CurrentRoom.ToString()));
                    break;
                case 'a':
                    playerhandle.MoveLeft(player, generator.GetRoom(player.CurrentRoom.ToString()));
                    break;
                case 'p':
                    po.takepotion(player);
                    break;
            }
        }
        public void battle()
        {

        } 
    }
}