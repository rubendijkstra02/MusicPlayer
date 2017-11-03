using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Playlist
    {
        private string playlistName;

        public string PlaylistName
        {
            get { return playlistName; }
            set { playlistName = value; }
        }

        public Playlist(string playlistName)
        {
            this.playlistName = playlistName;
         
        }
    }
}
