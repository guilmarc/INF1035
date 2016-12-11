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
        //Core.Model.Player player = new Core.Model.Player("jean"); 
        //const string XMLName = "SavedGames";
        
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = player;


            try
            {
                SavedGames.Games = Extensions.XmlToObject<List<Core.Model.Player>>(SavedGames.XMLName,true);
                ListSavedGames.ItemsSource = SavedGames.Games;
            }
            catch (Exception ex )// no item yet 
            {
                string normal = "if empty collection" + ex.Message;
            }
            if (SavedGames.Games == null)
            {
                SavedGames.Games = new List<Core.Model.Player>();
            }

        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            //Core.Model.Player player = new Core.Model.Player(PlayerName.Text);
            SavedGames.LoadedPlayer = new Core.Model.Player(PlayerName.Text);
            this.DataContext = SavedGames.LoadedPlayer;

            SavedGames.Games.Add(SavedGames.LoadedPlayer);
            SavedGames.Games.XmlSerialize(SavedGames.XMLName, true);
            Home.Visibility = Visibility.Collapsed;
            AppGrid.Children.Add(new SelectNewMonster(true) { Visibility = Visibility.Visible });
            //SwitchToNextWindow(Action.New);




        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {

            var selectedPlayer = (Core.Model.Player)ListSavedGames.SelectedItem;

            SavedGames.LoadedPlayer = SavedGames.Games.Single(x => x.Name == selectedPlayer.Name);
            this.DataContext = SavedGames.LoadedPlayer;

            Home.Visibility = Visibility.Collapsed;
            AppGrid.Children.Remove(TrainerHome);
            AppGrid.Children.Add(new TrainerHome(true) { Name = "TrainerHome", Visibility = Visibility.Visible });

            //this.SwitchToNextWindow(Action.Load);

        }

        private enum Action
        {
            New =1,
            Load=2
        }

        private void SwitchToNextWindow(Action action)
        {
            switch (action)
            {
                case Action.New:
                    var win2 = new SelectNewMonster();
                   // win2.Show();
                    break;
                case Action.Load:
                    throw new NotImplementedException();
                    //break;
            }

            this.Close();
        }
    }
}
