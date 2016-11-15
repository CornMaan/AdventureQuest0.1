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
                    Console.WriteLine("Are you sure you want to use a potion?");
                    string areyousure = Console.ReadLine();
                    areyousure 
                    if (potion == 0)
                    {
                        Console.WriteLine("You don't have any potions left");
                    }
                    else
                    {
                        Console.WriteLine("You gain 60 life");
                        player.hp = player.hp + 60;
                    }
                    break;
            }
        }
    }
}