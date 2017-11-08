using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessLayer;

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for Hoofdmenu.xaml
    /// </summary>
    public partial class Hoofdmenu : Window
    {
        Genre newGenre = new Genre();
        BusinessLayer.Album album = new Album();
        List<Track> tracklist = new List<Track>();
        List<Album> albumlist = new List<Album>();
        Speler speler = new Speler();
        public Hoofdmenu()
        {
            InitializeComponent();
            albumlist = album.getAllAlbums();
            dgAlbums.ItemsSource = albumlist;
        }

        private void label5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            Hoofdmenu windo2 = new Hoofdmenu();
            windo2.Close();
            window1.Show();
        }

        private void dgAlbums_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentAlbum = dgAlbums.SelectedItem as Album;
            //tracklist = currentAlbum.getTracks();
            //Methode gettracks maken, zelfde als getalbums, en daarna met een foreach kijken of de albumnaam gelijk is aan de benodigde album naam.
            dgTracks.ItemsSource = tracklist;
            imgFront.Source = currentAlbum.Frontcover;
            tbBio.Text = currentAlbum.Biografie;
            tbAlbumName.Content = currentAlbum.AlbumNaam;
        }

        private void dgTracks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var track = dgTracks.SelectedItem as Track;
            speler.PlayTrack(track);
            tbTrackTitle.Content = track.Title;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            speler.Play();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            speler.Pause();
        }
    }

}
