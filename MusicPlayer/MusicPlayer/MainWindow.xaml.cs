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

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenreOpslaan_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGenreToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (tb_genre.Text == "")
            {
                MessageBox.Show("Voer aub een genre in!");
            }
            else
            {
                string newgenre = tb_genre.Text;
                Genre newGenre = new Genre();
                newGenre.FillGenres(newgenre);
                MessageBox.Show(newGenre.Getgenres());
            }
        }
    }
}
