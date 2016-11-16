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

        public void AddItem(Item i, Player p)
        {
            if (p.klasse.Equals(i.klasse))
            {
                inventory.Add(i);
                p.power = p.power + i.itempower;
            }
            else
            {
                Console.WriteLine("You can not use this item, because of your class");
            }
        }
        public void addmob (Mob m)
        {
            battle.Add(m);
        }
        public void Addclass(Klasse k, Player p)
        {
            if (p.klasse.Equals(klasse))
            {
                p.klasse = k.navn;
            }
        }
    }
}
