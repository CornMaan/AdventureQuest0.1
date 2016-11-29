using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class Potion
    {
        public int number;
        public int hp;
        public Potion()
        {
            this.number = 5;
            this.hp = 60;
        }
        public void takepotion(Player p)
        {
            Console.WriteLine("Are you sure you want to take a potion?");
            string input = Console.ReadLine();
            if (input.ToLower().Equals("yes") || input.ToLower().Equals("y"))
            {
                if (number == 0)
                {
                    Console.WriteLine("You don't have any potions left");
                }
                else
                {
                    Console.WriteLine("You take a potion");
                    p.hp += hp;
                    if (p.hp < p.maxhp)
                    {
                        p.hp = p.maxhp;
                    }
                    number -= 1;
                }
            }
        }
    }
}
