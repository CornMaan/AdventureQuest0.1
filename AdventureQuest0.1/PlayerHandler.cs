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
            p.CurrentRoom = p.CurrentRoom.north;
            r.BattleMobs(w, p, po);
            r.GetItems(p);
            r.GetPotions(po);
        }
        public void MoveDown(Player p, Room r, Potion po, WorldGenerator w)
        {
            p.CurrentRoom = p.CurrentRoom.south;
            r.BattleMobs(w, p, po);
            r.GetItems(p);
            r.GetPotions(po);
        }
        public void MoveRight(Player p, Room r, Potion po, WorldGenerator w)
        {
            p.CurrentRoom = p.CurrentRoom.east;
            r.BattleMobs(w, p, po);
            r.GetItems(p);
            r.GetPotions(po);
        }
        public void MoveLeft(Player p, Room r, Potion po, WorldGenerator w)
        {
            p.CurrentRoom = p.CurrentRoom.west;
            r.BattleMobs(w, p, po);
            r.GetItems(p);
            r.GetPotions(po);
        }
    }
}
