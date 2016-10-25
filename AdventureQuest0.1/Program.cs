using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldGenerator w = new WorldGenerator();
            w.PrintWorld();
            Console.ReadLine();
         
        }
    }
}
