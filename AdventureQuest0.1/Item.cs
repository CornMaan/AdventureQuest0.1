using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class Item
    {
        public string navn;
        public int itempower;
        public string klasse;
        public Item(string navn, int itempower, string klasse)
        {
            this.navn = navn;
            this.itempower = itempower;
            this.klasse = klasse;
        }
    }
}
