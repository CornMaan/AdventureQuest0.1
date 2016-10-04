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
        public List<Item> inventory = new List<Item>(); 

        public void AddItem(Item i)
        {
            inventory.Add(i);
            switch (curentRoom)
            {
                case "bambiRoom":
                    Console.WriteLine("Du fandt et rensdyr horn under isen");
                    break;
            }
        }
    }

    public class Item
    {
        public string navn;
    }
}
