using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BusinessLayer
{
    public static class AlbumImage
    {
        /// <summary>
        /// Converts a byte[] to a bitmapimage
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static BitmapImage Image(byte[] array)
        {
            using (var ms = new System.IO.MemoryStream(array))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();;
                image.CacheOption = BitmapCacheOption.OnLoad; // here
                image.StreamSource = ms;
                image.EndInit();

                return image;
            }
        }
    }
}