using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class MenuScreen
    {
        public void Menu ()
        {
            Console.WriteLine();
            Console.WriteLine("         ██████╗░░█████╗░░█████╗░██╗░░██╗  ██████╗░░█████╗░██████╗░███████╗██████╗░      ");
            Console.WriteLine("         ██╔══██╗██╔══██╗██╔══██╗██║░██╔╝  ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗      ");
            Console.WriteLine("         ██████╔╝██║░░██║██║░░╚═╝█████═╝░  ██████╔╝███████║██████╔╝█████╗░░██████╔╝      ");
            Console.WriteLine("         ██╔══██╗██║░░██║██║░░██╗██╔═██╗░  ██╔═══╝░██╔══██║██╔═══╝░██╔══╝░░██╔══██╗      ");
            Console.WriteLine("         ██║░░██║╚█████╔╝╚█████╔╝██║░╚██╗  ██║░░░░░██║░░██║██║░░░░░███████╗██║░░██║      ");
            Console.WriteLine("         ╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░░╚═╝╚═╝░░░░░╚══════╝╚═╝░░╚═╝      ");
            Console.WriteLine("                 ░██████╗░█████╗░██╗░██████╗░██████╗░█████╗░██████╗░░██████╗             ");
            Console.WriteLine("                 ██╔════╝██╔══██╗██║██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝             ");
            Console.WriteLine("                 ╚█████╗░██║░░╚═╝██║╚█████╗░╚█████╗░██║░░██║██████╔╝╚█████╗░             ");
            Console.WriteLine("                 ░╚═══██╗██║░░██╗██║░╚═══██╗░╚═══██╗██║░░██║██╔══██╗░╚═══██╗             ");
            Console.WriteLine("                 ██████╔╝╚█████╔╝██║██████╔╝██████╔╝╚█████╔╝██║░░██║██████╔╝             ");
            Console.WriteLine("                 ╚═════╝░░╚════╝░╚═╝╚═════╝░╚═════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░             ");
            Console.WriteLine();
            Console.WriteLine("\n                                    PRESS ENTER TO START                               ");
  
            Start:

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                RoundSelecton selectionScreen = new RoundSelecton();
                selectionScreen.Rounds();
            }
            else
            {
                goto Start;
            }
        }
    }
}
