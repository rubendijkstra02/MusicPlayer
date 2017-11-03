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
using System.Reflection.Emit;


namespace BusinessLayer
{
    public class Album
    {

        
     


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

        public Album(string biografie, BitmapImage frontcover, BitmapImage backcover, Genre genrealbum)
        {
            this.biografie = biografie;
            this.frontcover = frontcover;
            this.backcover = backcover;
            this.genrealbum = genrealbum;
        }
    }
}
