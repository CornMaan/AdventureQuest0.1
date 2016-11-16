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
        public int maxhp;
        public int power;
        public Room CurrentRoom;
        public List<Item> inventory = new List<Item>();
        public string klasse;

        public Player()
        {
            this.hp = 200;
            this.power = 1;
        }
        // problem at skulle kalde player i world generator klassen fordi playeren bliver oprettet i world
        public void AddItem(Item i, Player p)
        {
            if (p.klasse.Equals(i.klasse))
            {
                inventory.Add(i);
                p.power = p.power + i.itempower;
                p.maxhp = p.maxhp + i.hp;
                p.hp = p.hp + i.hp;
            }
            else
            {
                Console.WriteLine("You can not use this item, because of your class");
            }
        }
        public void AddKlasse(Klasse k, Player p)
        {
            if (p.klasse.Equals(klasse))
            {
                p.klasse = k.navn;
                p.power = p.power + k.klassepower;
                p.maxhp = p.maxhp + k.hp;
                p.hp = p.hp + k.hp;
            }
        }

    }
}
