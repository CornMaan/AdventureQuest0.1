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
            Room r1 = new Room("Spawn", "Dette er starten på et eventyr");
            Room r2 = new Room("Bambi hjørnet", "Vent 8 sekunder og få et rensdyrhorn, som forvandler dig til et rensdyr.");
            Room r3 = new Room("De vilde kaniners hule", "Pas på de vilde og farlige kaniner.");
            Room r4 = new Room("Spooky scary skeletons", "Hvis du dør her bliver du til en spooky scary skeleton.");
            Room r5 = new Room("Sasquatch dungeon", "Pas på den farlige sasquatch.");
            Room r6 = new Room("Dream room", "Vent 10 sekunder og få et item.");
            Room r7 = new Room("De ensomme spøgelser", "Dø her og bliv til et ensomt spøgelse.");
            Room r8 = new Room("De lillae blomsters eng", "Vent her og få en kiste.");
            Room r9 = new Room("Preperation room", "Du har nu fuldt liv.");
            Room r10 = new Room("Blue eyes white dragon!", "Slå dragen ihjel og kom videre til næste level!");
            Room r11 = new Room("Room of death", "Du dør.");
            Room r12 = new Room("Item of mass destruction", "Du bliver uovervindelig.");
            Room r13 = new Room("Teleport til level 2", "Du er nu igennem første level.");
            Room r14 = new Room("Spawn 2", "Starten af andet level.");
            Room r15 = new Room("The fairy crib", "Dette er et værtshus. Pas på du ikke drikker dig selv ihjel.");
            Room r16 = new Room("Drage kugler", "Pas på dragekuglerne. De slår hårdt.");
            Room r17 = new Room("Ulvens sovekammer", "Bevæg dig langsomt og få et godt item.");
            Room r18 = new Room("Peter plyds og co.", "Pas på, peter plyds er sulten!");
            Room r19 = new Room("Asylcentret", "Her passer staten på dig. Her hygger alle asylansøgerene sig på statens regning. Du får fuldt liv.");
            Room r20 = new Room("Triwizard maze", "Kom igennem denne labyrint og kom videre til den sidset boss!");
            Room r21 = new Room("Mufasa", "Dette er den afsluttende kamp! Slå løven ihjel og skub ham udover klippeskrænten!");

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