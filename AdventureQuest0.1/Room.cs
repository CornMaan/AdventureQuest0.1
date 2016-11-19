﻿using System;
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
        public List<Item> items;
        public List<Mob> mobs;
        public Room(string navn, string beskrivelse)
        {
            this.navn = navn;
            this.beskrivelse = beskrivelse;
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
        public void ListMobs()
        {
            if (mobs.Count > 0)
            {
                Console.WriteLine("Du ser : ");
                foreach (Mob i in mobs)
                {
                    Console.WriteLine(i.navn);
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
        public void AddItem(Item i)
        {
            this.items.Add(i);
        }
        public void AddMob(Mob i)
        {
            this.mobs.Add(i);
        }


        public override string ToString()
        {
            string s = "";
            s += "Navn: " + navn + "\n";
            s += "Beskrivelse: " + beskrivelse + "\n";
            if (north != null) s += "Udgang til: " + north.navn + "\n";
            if (south != null) s += "Udgang til: " + south.navn + "\n";
            if (west != null) s += "Udgang til: " + west.navn + "\n";
            if (east != null) s += "Udgang til: " + east.navn + "\n";
            return s;
        }




    }
}