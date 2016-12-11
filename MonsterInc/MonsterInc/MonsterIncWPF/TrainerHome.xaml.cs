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
    /// Logique d'interaction pour TrainerHome.xaml
    /// </summary>
    public partial class TrainerHome : UserControl
    {
        public TrainerHome()
        {
            
        }
        public TrainerHome(bool affiche)
        {
            InitializeComponent();
            this.DataContext = SavedGames.LoadedPlayer;
            DifficultyListBox.ItemsSource = DifficultyData.Difficulty;
        }

        private void MenuQuitBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Home.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }

        private void ActiveMonsterBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuArenaBtn_Click(object sender, RoutedEventArgs e)
        {
            DifficultyPanel.Visibility = Visibility.Visible;
            MenuPanel.Visibility = Visibility.Collapsed;
        }

        private void MenuStoreBtn_Click(object sender, RoutedEventArgs e)
        {
            ActiveGrid.Children.Add(new ItemShop() { Visibility = Visibility.Visible });

            TrainerHomeGrid.Visibility = Visibility.Collapsed;

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MenuPanel.Visibility = Visibility.Visible;
            DifficultyPanel.Visibility = Visibility.Collapsed;
        }

        private void DifficultyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t = SavedGames.mainWindow.AppGrid.Children[SavedGames.trainerHomeForm];
            ((TrainerHome)t).TrainerHomeGrid.Visibility = Visibility.Collapsed;
            ((TrainerHome)t).CombatGrid.Visibility = Visibility.Visible;
        }
    }
}
