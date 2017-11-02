using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class PlaylistTrack
    {
        private Track trackPlaylist;

        public Track TrackPLaylist
        {
            get { return trackPlaylist; }
            set { trackPlaylist = value; }
        }


        private Playlist playlist;

        public Playlist Playlist
        {
            get { return playlist; }
            set { playlist = value; }
        }

    }
}
