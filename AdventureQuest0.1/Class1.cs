using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class World
    {
        List<Room> rooms;
        public World()
        {
            rooms = new List<Room>();
            Room r1 = new Room("Mark", "En stor og grøn mark med masser af smukke planter og dyr");
            Room r2 = new Room("Hus", "Indgangen til et mørkt hus");
            Room r3 = new Room("Mørkt rum", "Et meget mørkt rum");
            Room r4 = new Room("Fangekælder", "Uhyggeligt rum med masser af sjove lyde, du kan ikke se noget i dette rum");
            Room r5 = new Room("Gyldent rum", "Et gyldent rum med en kiste midt i det hele");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);

            r1.AddEast(r2);
            r2.AddWest(r1);
            r2.AddNorth(r3);
            r3.AddSouth(r2);
            r3.AddEast(r4);

        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }


    }
}