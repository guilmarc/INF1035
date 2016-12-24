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
using Core;
using Core.Model;

namespace MonsterIncWPF
{
    /// <summary>
    /// Logique d'interaction pour SelectNewMonster.xaml
    /// </summary>
    public partial class SelectNewMonster : UserControl
    {
        public SelectNewMonster()
        {
        }

        ObservableCollection<Core.Model.Monster> selectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);
        public SelectNewMonster(bool affiche)
        {
            string nomPlayer = SavedGames.LoadedGame.HumanPlayer.Name;
            InitializeComponent();
            SavedGames.LoadedGame.HumanPlayer.Trainer = new Core.Model.Trainer();

            //SavedGames.LoadedGame.HumanPlayer.Trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);
            //selectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);
            this.DataContext = SavedGames.LoadedGame.HumanPlayer;

            ListSelectTempMonsters.ItemsSource = selectTempMonsters;
            ListAffinity.ItemsSource = Enum<Element>.GetNames();
            TrainerTextBox.Text = nomPlayer;
        }

        private void ListSelectTempMonsters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterDetails detailControlOpen = new MonsterDetails(selectTempMonsters[ListSelectTempMonsters.SelectedIndex]);

            DetailsControl.Content = detailControlOpen;

            DetailsControl.Visibility = Visibility.Visible;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ListSelectTempMonsters.SelectedItem == null) MessageBox.Show("Please select your new monster");
                else if (MonsterNameTextBox.Text == "") MessageBox.Show("Please enter a name for your new monster");
                else if (ListAffinity.SelectedItem == null) MessageBox.Show("Please choose your affinity");
                else
                {
                    SavedGames.LoadedGame.HumanPlayer.Trainer.Affinity = Core.Extensions.ToEnum<Element>(ListAffinity.SelectedValue.ToString());
                    SavedGames.LoadedGame.HumanPlayer.Trainer.ActiveMonsters = new List<Core.Model.Monster>();
                    SavedGames.LoadedGame.HumanPlayer.Trainer.ActiveMonsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);
                    SavedGames.LoadedGame.HumanPlayer.Trainer.Name = TrainerTextBox.Text;
                    SavedGames.LoadedGame.HumanPlayer.Trainer.Monsters = new List<Core.Model.Monster>();
                    SavedGames.LoadedGame.HumanPlayer.Trainer.Monsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);
                    SavedGames.LoadedGame.HumanPlayer.Trainer.Monsters[0].NickName = MonsterNameTextBox.Text;
                    SavedGames.LoadedGame.HumanPlayer.Trainer.ActiveMonsters[0] = SavedGames.LoadedGame.HumanPlayer.Trainer.Monsters[0];
                    SavedGames.LoadedGame.HumanPlayer.Trainer.ActiveMonster = SavedGames.LoadedGame.HumanPlayer.Trainer.Monsters[0];
                    //SavedGames.Games.XmlSerialize(SavedGames.XMLName, true);
                    SavedGames.LoadedGame.Save();

                    this.Visibility = Visibility.Collapsed;

                    SavedGames.trainerHomeForm = ((MainWindow)System.Windows.Application.Current.MainWindow).AppGrid.Children.Add(new TrainerHome(true) { Name = "TrainerHome2", Visibility = Visibility.Visible });
                }
            }
            catch (Exception ex)
            {
                var a = "plante ici";
                throw;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Home.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
