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
using Core.Database;

namespace MonsterIncWPF
{
    /// <summary>
    /// Logique d'interaction pour Difficulty.xaml
    /// </summary>
    public partial class Difficulty : UserControl
    {
        public Difficulty()// difficulty
        {
            //Core.Database.DifficultyData difficultyData = new DifficultyData();
            
            //this.DataContext = Core.Universe.Difficulties;
            InitializeComponent();
            DifficultyListBox.ItemsSource = DifficultyData.Difficulty;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).TrainerHome.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }

        private void DifficultyButton1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).TrainerHome.Visibility = Visibility.Collapsed;
            ((MainWindow)System.Windows.Application.Current.MainWindow).TrainerHome.CombatGrid.Visibility = Visibility.Visible;
        }
    }
}
