using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class Player
    {
        public string navn;
        public int hp;
        public int power;
        public Room CurrentRoom;
        public List<Item> inventory = new List<Item>();
        public string klasse;

        public Player()
        {
            this.hp = 200;
            this.power = 1;
        }

        public void AddItem(Item i)
        {
            inventory.Add(i);
        }
    }
}
