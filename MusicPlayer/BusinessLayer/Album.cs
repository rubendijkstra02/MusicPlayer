using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Media;
using DataLayer;


namespace BusinessLayer
{
    /// <summary>
    /// album
    /// </summary>
    public class Album
    {

        
        /// <summary>
        /// ID van het album Deze moet automatisch opgehoogd worden bij elk nieuw album
        /// </summary>
        private string albumNaam;

        public string AlbumNaam
        {
            get { return albumNaam; }
            set { albumNaam = value; }
        }

        public int Year { get; set; }

        public string Artist { get; set; }



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

        public TrackList trackList { get; internal set; }

        public string GetAlbumGenre()
        {
            string GenreNaam = genrealbum.Name;
            return GenreNaam;
        }

        public byte[] FrontToBytes()
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(frontcover));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        public byte[] BackToBytes()
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(backcover));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        public BitmapImage GetImage()
        {
            return Frontcover;
        }

        public string SetNaam(string naam)
        {
            
            return AlbumNaam;
        }

        public void Create()
        {
            //jaar toevoegen aan class
            AlbumConnection.InsertAlbum(this.albumNaam, this.Artist, this.biografie, this.FrontToBytes(), this.BackToBytes(), 0, this.genrealbum.Name);
        }

        public List<Album> getAllAlbums()
        {
            SqlConnection connection = Connection.GetConnection();

            List<Album> albums = new List<Album>();
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectAlbums";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Namen in blokhaakjes aanpassen naar namen in je database
                Album album = new Album();
                album.albumNaam = reader["Title"].ToString();
                album.Artist = reader["Artist"].ToString();
                album.Biografie = reader["Autobiography"].ToString();
                album.frontcover = AlbumImage.Image((byte[])reader["FrontCover"]);
                album.backcover = AlbumImage.Image((byte[])reader["BackCover"]);
                album.genrealbum.Name = reader["Genre"].ToString();
                if (reader["Year"].ToString() != "")
                {
                    album.Year = Convert.ToInt32(reader["Year"]);
                }
                albums.Add(album);
            }


            return albums;
        }

    }
}
