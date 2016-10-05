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
            Room r8 = new Room("De lilla blomsters eng", "Vent her og få en kiste.");
            Room r9 = new Room("Preperation room", "Du har nu fuldt liv.");
            Room r10 = new Room("Blue eyes white dragon!", "Slå dragen ihjel og kom videre til næste level!");
            Room r11 = new Room("Room of death", "GÅ HERIND DRENGE!");
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
            Room r22 = new Room("Hemmeligt rum", "Mystery shit");

            Item i1 = new Item("Dagger", 32);
            r2.AddItem(i1);

            
            
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r6);
            rooms.Add(r7);
            rooms.Add(r8);
            rooms.Add(r9);
            rooms.Add(r10);
            rooms.Add(r11);
            rooms.Add(r12);
            rooms.Add(r13);
            rooms.Add(r14);
            rooms.Add(r15);
            rooms.Add(r16);
            rooms.Add(r17);
            rooms.Add(r18);
            rooms.Add(r19);
            rooms.Add(r20);
            rooms.Add(r21);
            rooms.Add(r22);



            r1.AddEast(r2);
            r1.AddWest(r4);
            r1.AddNorth(r3);
            r1.AddSouth(r22);
            r2.AddEast(r5);
            r3.AddNorth(r6);
            r4.AddNorth(r7);
            r5.AddNorth(r8);
            r6.AddWest(r9);
            r7.AddEast(r9);
            r7.AddWest(r10);
            r10.AddNorth(r11);
            r10.AddSouth(r12);
            r10.AddEast(r13);
            r14.AddEast(r15);
            r15.AddNorth(r16);
            r15.AddSouth(r17);
            r16.AddEast(r19);
            r17.AddEast(r18);
            r18.AddNorth(r20);
            r19.AddSouth(r20);
            r20.AddWest(r21);


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