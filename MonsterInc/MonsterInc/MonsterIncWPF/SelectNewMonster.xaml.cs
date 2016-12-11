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

        public SelectNewMonster(bool affiche)
        {
            string nomPlayer = SavedGames.LoadedPlayer.Name;
            InitializeComponent();
            SavedGames.LoadedPlayer.Trainer = new Core.Model.Trainer();

            SavedGames.LoadedPlayer.Trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);
            this.DataContext = SavedGames.LoadedPlayer;   
            ListAffinity.ItemsSource = Enum<Core.Element>.GetNames();
            TrainerTextBox.Text = nomPlayer;
        }

        //private Core.Model.Trainer trainer = new Core.Model.Trainer("Jean", 0);
        //private MonsterDetails detailControlOpen;


        private void ListSelectTempMonsters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterDetails detailControlOpen = new MonsterDetails(SavedGames.LoadedPlayer.ActiveTrainer.SelectTempMonsters[ListSelectTempMonsters.SelectedIndex]);

            DetailsControl.Content = detailControlOpen;

            DetailsControl.Visibility = Visibility.Visible;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(ListSelectTempMonsters.SelectedItem == null) MessageBox.Show("Please select your new monster");
                else if (MonsterNameTextBox.Text == "")MessageBox.Show("Please enter a name for your new monster");
                else if (ListAffinity.SelectedItem == null) MessageBox.Show("Please choose your affinity");
                else 
                {
                    SavedGames.LoadedPlayer.Trainer.Affinity = Core.Extensions.ToEnum<Core.Element>(ListAffinity.SelectedValue.ToString());
                    SavedGames.LoadedPlayer.Trainer.ActiveMonsters = new List<Core.Model.Monster>();
                    SavedGames.LoadedPlayer.Trainer.ActiveMonsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);
                    SavedGames.LoadedPlayer.Trainer.Name = TrainerTextBox.Text;
                    SavedGames.LoadedPlayer.Trainer.Monsters = new List<Core.Model.Monster>();
                    SavedGames.LoadedPlayer.Trainer.Monsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);
                    SavedGames.LoadedPlayer.Trainer.Monsters[0].NickName = MonsterNameTextBox.Text;
                    SavedGames.Games.XmlSerialize(SavedGames.XMLName, true);




                    this.Visibility = Visibility.Collapsed;

                    SavedGames.trainerHomeForm=((MainWindow)System.Windows.Application.Current.MainWindow).AppGrid.Children.Add(new TrainerHome(true) {Name="TrainerHome2", Visibility = Visibility.Visible });
                   

                }
                

            }
            catch (Exception ex)
            {
                var a = "plante ici";
                throw;
            }




            //Core.Engine.Trainer = trainer;


        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //DependencyObject parentObject = VisualTreeHelper.GetParent(this);
            ((MainWindow)System.Windows.Application.Current.MainWindow).Home.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
