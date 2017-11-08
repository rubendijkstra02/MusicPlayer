using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public static class PartlyAlbumInitializer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Album InitializeAlbum()
        {
            try
            {
                //Read album from file
                Dictionary<string, byte[]> albumAttributes = FileIO.GetAlbum();

                //store temporarly the tracks from the album
                Dictionary<string, byte[]> songs = new Dictionary<string, byte[]>();
                if (albumAttributes.ContainsKey("autobiography") && albumAttributes.ContainsKey("frontcover")
                    && albumAttributes.ContainsKey("backcover") && albumAttributes.Count > 3)
                {
                    for (int i = 3; i < albumAttributes.Count; i++)
                    {
                        songs.Add(albumAttributes.Keys.ElementAt(i), albumAttributes.Values.ElementAt(i));
                    }
                }
                else
                    throw new ArgumentException("Error in album storage structure. \r\nRead the manual for storing an album on your hard drive");

                //Initialize the album partly
                Album partlyAlbum = new Album
                {
                    /* 
                        System.Text.Encoding.UTF8.GetString(byte[], 0, btye[].Length)
                        This code converts the autobiography, stored as a byte[],  to a string
                    */
                    Biografie = System.Text.Encoding.UTF8.GetString(albumAttributes["autobiography"], 0, albumAttributes["autobiography"].Length),
                    Frontcover = AlbumImage.Image(albumAttributes["frontcover"]),
                    Backcover = AlbumImage.Image(albumAttributes["backcover"]),
                    trackList = new TrackList(songs)
                };
                return partlyAlbum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
