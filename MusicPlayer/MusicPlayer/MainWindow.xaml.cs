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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLayer;
using System.IO;
using Microsoft.Win32;
using Path = System.IO.Path;


namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        Genre newGenre = new Genre();
        Album currentAlbum = new Album();
        BusinessLayer.Genre genre = new Genre();
        List<string> genres = new List<string>();
        public MainWindow()
        {
            genres = genre.Getgenres();
            InitializeComponent();
            cbGenre.ItemsSource = genres;
        }

        private void GenreOpslaan_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void label1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow window2 = new MainWindow();
            Hoofdmenu window1 = new Hoofdmenu();
            window2.Close();
            window1.Show();
            

        }

        private void btnGenreToevoegen_Click_1(object sender, RoutedEventArgs e)
        {
            if (tb_genre.Text == "")
            {
                MessageBox.Show("Voer aub een genre in!");
            }
            else
            {
                string newgenre = tb_genre.Text;
                newGenre.FillGenres(newgenre);
            }

            
           
        }

        private void btnUploadAlbum_Click(object sender, RoutedEventArgs e)
        {
            currentAlbum = PartlyAlbumInitializer.InitializeAlbum();

            imgFront.Source = currentAlbum.Frontcover;
            imgBack.Source = currentAlbum.Backcover;
            tbBio.Text = currentAlbum.Biografie;
        }

        private void SaveAlbum(object sender, RoutedEventArgs e)
        {
            currentAlbum.Create();
        }
    }
}
