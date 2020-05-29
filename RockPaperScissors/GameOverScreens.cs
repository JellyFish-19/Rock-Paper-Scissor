using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RockPaperScissors
{
    class GameOverScreens
    {
        public void PlayerWon(GameScreen gameScreen)
        {
            
            Console.Clear();
            gameScreen.ScoreBoard();
            Console.WriteLine("                          _                ");
            Console.WriteLine("                         / )               ");
            Console.WriteLine("                       .' /                ");
            Console.WriteLine("                   ---'  (____             ");
            Console.WriteLine("                             _)            ");
            Console.WriteLine("                             __)           ");
            Console.WriteLine("                            __)            ");
            Console.WriteLine("                   ---.______)             ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          █  █ █▀▀█ █  █ 　 █   █ █▀▀█ █▀▀▄  ");
            Console.WriteLine("          █▄▄█ █  █ █  █ 　 █▄█▄█ █  █ █  █  ");
            Console.WriteLine("          ▄▄▄█ ▀▀▀▀  ▀▀▀ 　  ▀ ▀  ▀▀▀▀ ▀  ▀  ");
            Restart();
        }

        public void ComputerWon(GameScreen gameScreen)
        {
            Console.Clear();
            gameScreen.ScoreBoard();
            Console.WriteLine("                       .-.                     ");
            Console.WriteLine("                       |U|                     ");
            Console.WriteLine("                       | |                     ");
            Console.WriteLine("                       | |                     ");
            Console.WriteLine("                      _| |_                    ");
            Console.WriteLine("                     | | | |-.                 ");
            Console.WriteLine("                    /|     ` |                 ");
            Console.WriteLine("                   | |       |                 ");
            Console.WriteLine("                   |         |                 ");
            Console.WriteLine("                   \\         /                ");
            Console.WriteLine("                    |       |                  ");
            Console.WriteLine("                    |       |                  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         █  █ █▀▀█ █  █ 　 █   █▀▀█ █▀▀ ▀▀█▀▀");
            Console.WriteLine("         █▄▄█ █  █ █  █ 　 █   █  █ ▀▀█   █  ");
            Console.WriteLine("         ▄▄▄█ ▀▀▀▀  ▀▀▀ 　 ▀▀▀ ▀▀▀▀ ▀▀▀   ▀  ");
            Restart();
        }

        public void Draw (GameScreen gameScreen)
        {
            Console.Clear();
            gameScreen.ScoreBoard();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                __..,,... .,,,,,.               ");
            Console.WriteLine("            ''''        ,'        ` .           ");
            Console.WriteLine("                      ,'  ,.  ..      `  .      ");
            Console.WriteLine("                      `.,'      ..           `  ");
            Console.WriteLine("            __..,.             .  ..     .      ");
            Console.WriteLine("                   ` .       .  `.  .` `        ");
            Console.WriteLine("                       ,  `.  `.  `._|,..       ");
            Console.WriteLine("                         .  `.  `..'            ");
            Console.WriteLine("                          ` -'`''               ");
            Console.WriteLine();
            Console.WriteLine("                 █▀▀▄ █▀▀█ █▀▀█ █   █           ");
            Console.WriteLine("                 █  █ █▄▄▀ █▄▄█ █▄█▄█           ");
            Console.WriteLine("                 ▀▀▀  ▀ ▀▀ ▀  ▀  ▀ ▀            ");
            Restart();
        }

        public void Restart ()
        {
            Console.WriteLine("\n                 PLAY AGAIN? (Y/N)              ");

            Start:
            var answer = Console.ReadLine();

            if (answer == "Y" || answer == "y")
            {
                RoundSelecton select = new RoundSelecton();
                select.Rounds();

            }
            else if (answer == "N" || answer == "n")
            {
                Console.WriteLine("\nGoodbye");
                return;
            }
            else
            {
                goto Start;
            }
        }
    }
}