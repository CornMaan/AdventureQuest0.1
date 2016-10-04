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
        public Room currentRoom;
        public List<Klasse> person = new List<Klasse>();
        public List<Item> inventory = new List<Item>(); 

        public void Addclass(Klasse c)
        {
            Klasse.Add(c);
            switch (curentRoom)
            {
                case "bambi hjørnet":
                    Console.WriteLine("Du fandt et rensdyr horn under isen, som forvandler dig til et rensdyr");

                    break;
                case "De ensomme spøgelser":
                    Console.WriteLine("Efter du dør, bliver du forvandlet til et Ensomt spøgelse");

                    break;
                case "Spooky scary skeletons":
                    Console.WriteLine("Efter du dør, bliver du forvandlet til et SSC");

                    break;
                case "Dream room":
                    Console.WriteLine("Du finder en staff of trickery, som forvandler dig til en warlock");

                    break;

            }
        }
        public void AddItem(Item i)
        {
            inventory.Add(i);
            if(currentRoom.Equals("Ulvens sovekammer") && person.Equals("rensdyr"))
            {
                Console.WriteLine("Du fandt nogle store tænder");

            }
            else if(currentRoom.Equals("Ulvens sovekammer") && person.Equals("Ensomt spøgelser"))
            {
                Console.WriteLine("Du fandt et lagn, som du tager hen over hovedet");

            }
            else if(currentRoom.Equals("Ulvens sovekammer") && person.Equals("Warlock"))
            {
                Console.WriteLine("Du fandt en uendelig mængde af sovepiller som du fra nu af altid bruge i kampen mod fjender");

            }
            else if(currentRoom.Equals("Ulvens sovekammer") && person.Equals("SSC"))
            {
                Console.WriteLine("Du fandt en rusten trumpet som du bruger du kan bruge til at skræmme fjender i kampen");

            }
            else if(currentRoom.Equals("Peterplys og co."))
            {
                Console.WriteLine("Du samlede en Honning krukke op fra peterplys lig. Honning krukken healer dig for 20hp når du bruger den");

            }
        }
    }

    public class Item
    {
        public string navn;
    }
    public class Klasse
    {
        public string navn;
    }
}
