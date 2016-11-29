﻿using System;
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
            r.BattleMobs();
        }
        public void MoveDown(Player p, Room r)
        {
            p.CurrentRoom = p.CurrentRoom.south;
            r.GetItems(p);
            r.BattleMobs();
        }
        public void MoveRight(Player p, Room r)
        {
            p.CurrentRoom = p.CurrentRoom.east;
            r.GetItems(p);
            r.BattleMobs();
        }
        public void MoveLeft(Player p, Room r)
        {
            p.CurrentRoom = p.CurrentRoom.west;
            r.GetItems(p);
            r.BattleMobs();
        }
    }
}
