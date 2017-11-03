using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Track
    {
       

        private byte[] song;

        public byte[] Song
        {
            get { return song; }
            set { song = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private int ranking;

        public int Ranking
        {
            get { return ranking; }
            set { ranking = value; }
        }

        private Album trackAlbum;

        public Album TrackAlbum
        {
            get { return trackAlbum; }
            set { trackAlbum = value; }
        }

        public Track()
        {
            
        }

        public Track(byte[] song, string title, string artist, int ranking, Album trackAlbum)
        {
         
            this.song = song;
            this.title = title;
            this.artist = artist;
            this.ranking = ranking;
            this.trackAlbum = trackAlbum;
        }
    }
}
