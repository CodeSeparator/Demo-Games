using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labir
{
    public static class Sound
    {
        static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.Fail);
        static SoundPlayer soundWin = new SoundPlayer(Properties.Resources.Win);
        static SoundPlayer soundKey = new SoundPlayer(Properties.Resources.Key);
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.Start);

        static bool soundEnabled = true;
        public static void soundOn()
        {
            soundEnabled = true;
        }
        public static void soundOff()
        {
            soundEnabled = false;
        }
        public static void playFail()
        {
            if(soundEnabled)
                soundFail.Play();
        }
        public static void playWin()
        {
            if (soundEnabled)
                soundWin.Play();
        }
        public static void playKey()
        {
            if (soundEnabled)
                soundKey.Play();
        }
        public static void playStart()
        {
            if (soundEnabled)
                soundStart.Play();
        }
    }
}
