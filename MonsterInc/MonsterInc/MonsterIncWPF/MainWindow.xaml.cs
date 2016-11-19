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
using Core;

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core.Model.Player player = new Core.Model.Player();
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = player;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Player = player;

            SelectMonster win2 = new SelectMonster();
            win2.Show();
            this.Close();

        }
    }
}
