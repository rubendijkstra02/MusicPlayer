using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BusinessLayer
{
    public class Speler : MediaPlayer
    {
        public void PlayTrack(Track track)
        {
            Close();
            Thread.Sleep(60);
            string path = AppDomain.CurrentDomain.BaseDirectory + "//tempTrack.mp3";
            File.WriteAllBytes(path, track.Song);
            Open(new Uri(path));
            Play();
        }
    }
}
