using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    class PlayerHandler
    {
        public void MoveUp(Player p, Room r)
        {
            p.CurrentRoom = p.CurrentRoom.north;
            r.GetItems(p);
            r.ListMobs();
        }
        public void MoveDown(Player p)
        {
            p.CurrentRoom = p.CurrentRoom.south;
        }
        public void MoveRight(Player p)
        {
            p.CurrentRoom = p.CurrentRoom.east;
        }
        public void MoveLeft(Player p)
        {
            p.CurrentRoom = p.CurrentRoom.west;
        }
    }
}
