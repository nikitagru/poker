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

namespace Pokerr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _numberOfPlayers;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Textbox_players_MouseEnter(object sender, MouseEventArgs e)
        {
            textbox_players.Text = "";
        }

        private void Button_start_Click(object sender, RoutedEventArgs e)
        {
            var temp = textbox_players.Text;
            try
            {
                _numberOfPlayers = Convert.ToInt32(temp);

                PlayWindow playWindow = new PlayWindow();
                playWindow.Width = 200 * _numberOfPlayers;
                playWindow.Height = 22 + (_numberOfPlayers * 2);
                playWindow.Show();
            } 
            catch
            {
                MessageBox.Show("Invalid Type of data");
            }
            
            
        }
    }
}
