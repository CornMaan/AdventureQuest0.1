using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class Room
    {
        public Room north;
        public Room south;
        public Room west;
        public Room east;
        public string navn;
        public string beskrivelse;
        public List<Klasse> klasse;
        public List<Item> items;
        public List<Mob> mobs;
        public int potion;
        public Room(string navn, string beskrivelse)
        {
            this.navn = navn;
            this.beskrivelse = beskrivelse;
            this.potion = 0;
            this.items = new List<Item>();
            this.mobs = new List<Mob>();
            this.klasse = new List<Klasse>();
        }

        public void AddNorth(Room r)
        {
            north = r;
        }

        public void AddSouth(Room r)
        {
            south = r;
        }
        public void AddWest(Room r)
        {
            west = r;
        }
        public void AddEast(Room r)
        {
            east = r;
        }
        public void BattleMobs(WorldGenerator w, Player p, Potion po)
        {
            if (mobs.Count > 0)
            {
                Console.WriteLine("Du ser : ");
                foreach (Mob m in mobs)
                {
                    Console.WriteLine(m.navn);
                    w.battle(m, p, po);
                }
            }
        }

        public void GetKlasse(Player p)
        {
            if (klasse.Count > 0)
            {
                if (p.klasse == "");
                {
                    Console.WriteLine("Du blev forvandlet til en/et ");
                    foreach (Klasse k in klasse)
                    {
                        Console.WriteLine(k.navn);
                        p.klasse = k.navn;
                        p.power += k.klassepower;
                        p.maxhp += k.hp;
                        p.hp += k.hp;
                    }
                }
            }
        }

        public void GetItems(Player p)
        {
            if (items.Count > 0)
            {
                Console.WriteLine("Du ser : ");
                foreach (Item i in items)
                {
                    Console.WriteLine(i.navn);
                    if (p.klasse.Equals(i.klasse))
                    {
                        Console.WriteLine("You equipped" + i.navn);
                        p.power += i.itempower;
                        p.maxhp += i.hp;
                        p.hp += i.hp;
                    }
                    else
                    {
                        Console.WriteLine("You can not use this item, because of your class");
                    }
                    
                }
            }
        }
        public void GetPotions(Potion po)
        {
            if (potion > 0)
            {
                Console.WriteLine("Du samler: " + potion + "potions op");
                po.number += potion;
            }
        }
        public void AddItem(Item i)
        {
            this.items.Add(i);
        }
        public void AddMob(Mob i)
        {
            this.mobs.Add(i);
        }
        public void Addpotion()
        {
            this.potion += 1;
        }
        public void addklasse(Klasse k)
        {
            this.klasse.Add(k);
        }

        public void Roomkultur()
        {
            string c = "";
            string n = "";
            string s = "";
            string w = "";
            string e = "";
            c += "Navn: " + navn + "\n";
            c += "Beskrivelse: " + beskrivelse + "\n";
            if (north != null) n += "Udgang til op: " + north.navn + "\n";
            if (south != null) s += "Udgang til ned: " + south.navn + "\n";
            if (west != null) w += "Udgang til venstre: " + west.navn + "\n";
            if (east != null) e += "Udgang til højre: " + east.navn + "\n";
            Console.WriteLine(c);
            Console.WriteLine(n);
            Console.WriteLine(s);
            Console.WriteLine(w);
            Console.WriteLine(e);
        }
    }
}