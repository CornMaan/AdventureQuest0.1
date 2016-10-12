using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class Mob
    {
        public string navn;
        public int difficulty;
        public int attack;
        public int hp;
        public Mob(string navn, int difficulty, int attack, int hp)
        {
            this.navn = navn;
            this.difficulty = difficulty;
            this.attack = attack;
            this.hp = hp;
        }
    }
}
