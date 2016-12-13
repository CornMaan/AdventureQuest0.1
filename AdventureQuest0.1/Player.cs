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
            this.maxhp = 200;
            this.klasse = "";
        }
        public void AddItem(Item i)
        {
            inventory.Add(i);
        }
        public void AddKlassetoplayer(Klasse k, Player p)
        {
            if (p.klasse.Equals(klasse))
            {
                p.klasse = k.navn;
                p.power += k.klassepower;
                p.maxhp += k.hp;
                p.hp += k.hp;
            }
        }
        public void dies()
        {
            if (hp <= 0)
            {

            }
        }


    }
}
