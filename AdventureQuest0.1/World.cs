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
