using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    class World
    {
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
        Player player = new Player();
        public void MovePlayer()
        {
            char input = char.Parse(Console.ReadLine());
            switch (input)
            {
                case 'w':
                    player.CurrentRoom = player.CurrentRoom.north;
                    break;
            }
        }
    }
}
