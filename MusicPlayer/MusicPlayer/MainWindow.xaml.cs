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
        Genre newGenre = new Genre();
        public MainWindow()
        {

            InitializeComponent();
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
    }
}
