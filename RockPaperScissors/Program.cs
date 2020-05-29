using System;
using System.Media;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundTrack player = new SoundTrack();
            player.Music();
            MenuScreen main = new MenuScreen();
            main.Menu();
        }
    }
}








            









