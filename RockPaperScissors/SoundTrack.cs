using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace RockPaperScissors
{
    class SoundTrack
    {
        public void Music ()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Super Mario Bros. 2 Overworld Theme.wav";
            player.Play();
        }
    }
}
