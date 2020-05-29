using System;
using System.Threading;


namespace RockPaperScissors
{
    class RoundSelecton 
    {
        public void Rounds()
        {
            Restart:
            Console.Clear();
            try
            {
                Console.WriteLine();
                Console.WriteLine("           █▀▀ █▀▀ █   █▀▀ █▀▀ ▀▀█▀▀ 　 ▀▀█▀▀ █  █ █▀▀ 　 █▀▀▄ █  █ █▀▄▀█ █▀▀▄ █▀▀ █▀▀█  ");
                Console.WriteLine("           ▀▀█ █▀▀ █   █▀▀ █     █   　   █   █▀▀█ █▀▀ 　 █  █ █  █ █ ▀ █ █▀▀▄ █▀▀ █▄▄▀  ");
                Console.WriteLine("           ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀   ▀   　   ▀   ▀  ▀ ▀▀▀ 　 ▀  ▀  ▀▀▀ ▀   ▀ ▀▀▀  ▀▀▀ ▀ ▀▀  ");
                Console.WriteLine("                            █▀▀█ █▀▀  █▀▀█ █▀▀█ █  █ █▀▀▄ █▀▀▄ █▀▀                       ");
                Console.WriteLine("                            █  █ █▀▀  █▄▄▀ █  █ █  █ █  █ █  █ ▀▀█                       ");
                Console.WriteLine("                            ▀▀▀▀ ▀    ▀ ▀▀ ▀▀▀▀  ▀▀▀ ▀  ▀ ▀▀▀  ▀▀▀                       ");

                Start:
                Console.WriteLine();
                Console.Write("\n                                          ROUNDS: ");
                
                int input = Convert.ToInt32(Console.ReadLine());
                //tryparse
                

                if (input > 30)
                {
                    Console.WriteLine("Maximum limit is 30\n");
                    goto Start;
                }
                else if (input <= 0)
                {
                    Console.WriteLine("Cant select zero or a negative number\n");
                    goto Start;
                }
                else
                {
                    GameScreen game = new GameScreen();
                    game.Game(input);
                }
            } catch
            {
                Console.WriteLine("Wrong input, please try again\n");
                goto Restart;
            }
        }
    }
}


 　
 　
 　


 






