using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Core.Model;

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for SelectActiveMonster.xaml
    /// </summary>
    public partial class SelectActiveMonster : UserControl
    {
        Trainer trainer = SavedGames.LoadedGame.HumanPlayer.Trainer;
        public SelectActiveMonster()
        {
            InitializeComponent();
            this.DataContext = trainer;
            MonsterListBox.ItemsSource = trainer.Monsters;

        }

        private void MonsterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterDetails detailControlOpen = new MonsterDetails(trainer.SelectTempMonsters[MonsterListBox.SelectedIndex]);

            MonsterDetailsControl.Content = detailControlOpen;

            MonsterDetailsControl.Visibility = Visibility.Visible;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility=Visibility.Collapsed;
        }
    }
}
