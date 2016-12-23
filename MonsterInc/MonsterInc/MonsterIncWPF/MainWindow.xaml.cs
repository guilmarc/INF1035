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
using Core.Model;

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
                ////SavedGames.Games = new List<Player>();
            try
            {
                //SavedGames.Games = Extensions.XmlToObject<List<Player>>(SavedGames.XMLName,true);
                ListSavedGames.ItemsSource = Universe.SavedGameFiles;
            }
            catch (Exception ex )// no item yet 
            {
                string normal = "if empty collection" + ex.Message;
            }
            //if (SavedGames.Games == null)
           // {
                
            //}
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            SavedGames.LoadedGame.HumanPlayer = new Player(PlayerName.Text);
            SavedGames.LoadedGame = new Game(SavedGames.LoadedGame.HumanPlayer);
            SavedGames.LoadedGame.Name = SavedGames.LoadedGame.HumanPlayer.Name;

            this.DataContext = SavedGames.LoadedGame.HumanPlayer;
            SavedGames.LoadedGame.Save();
            SavedGames.LoadedGame.Save("jean");

            Home.Visibility = Visibility.Collapsed;
            AppGrid.Children.Add(new SelectNewMonster(true) { Visibility = Visibility.Visible });
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            string gameName = ListSavedGames.SelectedItem.ToString();
            SavedGames.LoadedGame = Core.Engine.LoadGameFromFile(gameName);

            this.DataContext = SavedGames.LoadedGame;

            Home.Visibility = Visibility.Collapsed;
            AppGrid.Children.Remove(TrainerHome);
            AppGrid.Children.Add(new TrainerHome(true) { Name = "TrainerHome", Visibility = Visibility.Visible });

        }

        private enum Action
        {
            New =1,
            Load=2
        }


        //private void SwitchToNextWindow(Action action)
        //{
        //    switch (action)
        //    {
        //        case Action.New:
        //            var win2 = new SelectNewMonster();
        //            break;
        //        case Action.Load:
        //            throw new NotImplementedException();
        //    }

        //    this.Close();
        //}
    }
}
