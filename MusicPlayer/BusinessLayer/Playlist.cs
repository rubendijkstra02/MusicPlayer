using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Playlist
    {
        private string playlistName;

        public string PlaylistName
        {
            get { return playlistName; }
            set { playlistName = value; }
        }

        private int playlistID;

        public int PlaylistID
        {
            get { return playlistID; }
            set { playlistID = value; }
        }

    }
}
