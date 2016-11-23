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
using System.ComponentModel;
using Core;

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core.Model.Player player = new Core.Model.Player();
        const string SavedGameXMLname = "SavedGames";
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = player;


            try
            {
                SavedGames.Games = Extensions.XmlToObject<List<Core.Model.Player>>(SavedGameXMLname,true);
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Player = player;

            SavedGames.Games.Add(Engine.Player);
            SavedGames.Games.XmlSerialize(SavedGameXMLname, true);
            //SwitchToNextWindow(Action.New);
            List1Layer.Visibility = Visibility.Visible;



        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {

            var selectedPlayer = (Core.Model.Player)ListSavedGames.SelectedItem;

            Engine.Player = SavedGames.Games.Single(x => x.Name == selectedPlayer.Name);

            //this.SwitchToNextWindow(Action.Load);

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
        //            var win2 = new SelectMonster();
        //            win2.Show();
        //            break;
        //        case Action.Load:
        //            throw new NotImplementedException();
        //            //break;
        //    }

        //    this.Close();
        //}
    }
}
