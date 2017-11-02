using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Media;


namespace BusinessLayer
{
    class Album
    {

        
        /// <summary>
        /// ID van het album Deze moet automatisch opgehoogd worden bij elk nieuw album
        /// </summary>
        private int albumID;

        public int AlbumID
        {
            get { return albumID; }
            set { albumID = value; }
        }



        /// <summary>
        /// Biografie van het album (max 250 charachters)
        /// </summary>
        private string biografie;

        public string Biografie
        {
            get { return biografie; }
            set { biografie = value; }
        }

        private BitmapImage frontcover;

        public  BitmapImage Frontcover
        {
            get { return frontcover; }
            set { frontcover = value; }
        }


        private BitmapImage backcover;

        public BitmapImage Backcover
        {
            get { return backcover; }
            set { backcover = value; }
        }


        private Genre genrealbum;

        public Genre GenreAlbum
        {
            get { return genrealbum; }
            set { genrealbum = value; }
        }

        
    }
}
