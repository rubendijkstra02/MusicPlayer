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
        Genre genre = new Genre();
        public Hoofdmenu()
        {
            InitializeComponent();
        }

        private void cb_genre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
          
        }

        private void label5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            Hoofdmenu windo2 = new Hoofdmenu();
            windo2.Close();
            window1.Show();
        }

        private void btntest_Click(object sender, RoutedEventArgs e)
        {
            foreach (var genre in genre.Getgenres())
            {
                cb_genre.Items.Add(genre);
            }
        }
    }

}
