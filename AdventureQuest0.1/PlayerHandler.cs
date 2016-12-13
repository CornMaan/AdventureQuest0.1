using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    class PlayerHandler
    {
        public void MoveUp(Player p, Room r, Potion po, WorldGenerator w)
        {
            if (p.CurrentRoom.north != null)
            {
                p.CurrentRoom = p.CurrentRoom.north;
                r = p.CurrentRoom;
                r.BattleMobs(w, p, po);
                r.GetItems(p);
                r.GetPotions(po);
                r.Roomkultur();
            }
            else
            {
                Console.WriteLine("There is no room here");
            }
        }
        public void MoveDown(Player p, Room r, Potion po, WorldGenerator w)
        {
            if (p.CurrentRoom.south != null)
            {
                p.CurrentRoom = p.CurrentRoom.south;
                r = p.CurrentRoom;
                r.BattleMobs(w, p, po);
                r.GetItems(p);
                r.GetPotions(po);
                r.Roomkultur();
            }
            else
            {
                Console.WriteLine("There is no room here");
            }
        }
        public void MoveRight(Player p, Room r, Potion po, WorldGenerator w)
        {
            if (p.CurrentRoom.east != null)
            {
                p.CurrentRoom = p.CurrentRoom.east;
                r = p.CurrentRoom;
                r.BattleMobs(w, p, po);
                r.GetItems(p);
                r.GetPotions(po);
                r.Roomkultur();
            }
            else
            {
                Console.WriteLine("There is no room here");
            }
        }
        public void MoveLeft(Player p, Room r, Potion po, WorldGenerator w)
        {
            if (p.CurrentRoom.west != null)
            {
                p.CurrentRoom = p.CurrentRoom.west;
                r = p.CurrentRoom;
                r.BattleMobs(w, p, po);
                r.GetItems(p);
                r.GetPotions(po);
                r.Roomkultur();
            }
            else
            {
                Console.WriteLine("There is no room here");
            }
        }
    }
}
