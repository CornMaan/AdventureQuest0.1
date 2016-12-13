using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuest0._1
{
    public class World
    {
        Player player = new Player();
        PlayerHandler playerhandle = new PlayerHandler();
        Potion po = new Potion();
        WorldGenerator generator = new WorldGenerator();
        // does not work, fordi man er ved at angive om hvad for noget hp og lignende den har.

        public World()
        {
            player.CurrentRoom = generator.GetRoom("Spawn");

        }
        public void HandleInput()
        {
            Console.WriteLine("The game is now starting");
            bool isRunning = true;
            while (isRunning)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("exit") || input.ToLower().Equals("e"))
                {
                    isRunning = false;
                }
                else if (player.hp <= 0)
                {
                    if (player.CurrentRoom.Equals(generator.GetRoom("SCC")))
                    {
                        // problemer med at vi skal angive hvad for en klasse det er, da klassen skal oprettes et eller andet sted,
                        // og højst sandsynligt skal "assignes" til et rum.
                        generator.Playerklasse(generator.FindKlasse("SSC"), player);
                        player.hp = player.maxhp;
                    }
                    else if (player.CurrentRoom.Equals(generator.GetRoom("De ensomme spøgelser")))
                    {
                         generator.Playerklasse(generator.FindKlasse("Ensomt spøgelse"), player);
                        player.hp = player.maxhp;
                    }
                    else
                    {
                        Console.WriteLine("You died");
                        Console.WriteLine("The game will now be closed");
                        isRunning = false;
                    }
                }
                else
                {
                    HandleMovement();
                }
            }
        }
        public void HandleMovement()
        {
            bool Keeponhandlingit = true;
            while (Keeponhandlingit)
            {
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case 'w':
                        playerhandle.MoveUp(player, player.CurrentRoom, po, generator);
                        break;
                    case 's':
                        playerhandle.MoveDown(player, player.CurrentRoom, po, generator);
                        break;
                    case 'd':
                        playerhandle.MoveRight(player, player.CurrentRoom, po, generator);
                        break;
                    case 'a':
                        playerhandle.MoveLeft(player, player.CurrentRoom, po, generator);
                        break;
                    case 'p':
                        po.takepotion(player);
                        break;
                    default:
                        Keeponhandlingit = false;
                        break;
                }
            }
        }
    }
}