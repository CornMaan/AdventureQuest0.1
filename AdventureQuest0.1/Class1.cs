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
            Room r1 = new Room("Spawn", "Dette er starten på et eventyr.");
            Room r2 = new Room("Bambi hjørnet", "Vent 8 sekunder med at bevæge dig videre, for ikke at dø.");
            Room r3 = new Room("De vilde kaniners hule", "Dette er et rum fyldt med vrede og vilde kaniner.");
            Room r4 = new Room("Spooky scary skeletons", "Hvis du dør her, bliver du til et spooky scary skeleton.");
            Room r5 = new Room("Sasquatch dungeon", "Pas på den farlige sasquatch ikke dræber dig!");
            Room r6 = new Room()

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