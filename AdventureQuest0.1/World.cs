using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class World
    {
        Player player = new Player();
        PlayerHandler playerhandle = new PlayerHandler();
        Potion po = new Potion();
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
                else if (player.hp <= 0)
                {
                    Console.WriteLine("You died");
                    Console.WriteLine("The game will now be closed");
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
                    playerhandle.MoveUp(player, player.CurrentRoom, po, generator);
                    break;
                case 's':
                    playerhandle.MoveDown(player, player.CurrentRoom, po, generator);
                    break;
                case 'd':
                    playerhandle.MoveRight(player, player.CurrentRoom, po, generator);
                    break;
                case 'a':
                    playerhandle.MoveLeft(player, player.CurrentRoom, po, generator);
                    break;
                case 'p':
                    po.takepotion(player);
                    break;
            }
        }
    }
}