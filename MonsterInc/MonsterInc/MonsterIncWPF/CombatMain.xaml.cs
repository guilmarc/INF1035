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
using Core.Model;

namespace MonsterIncWPF
{
    /// <summary>
    /// Logique d'interaction pour CombatMain.xaml
    /// </summary>
    public partial class CombatMain : UserControl
    {
        public CombatMain()
        {
            InitializeComponent();
            this.DataContext = SavedGames.LoadedCombat;

            Trainer gentilTrainer = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Human).First().Trainer;
            FriendlyMonster.Content = gentilTrainer.ActiveMonster.NickName;
            FriendlyMonsterType.Content = gentilTrainer.ActiveMonster.Template.Name;
            FriendlyMonsterLPActual.Content = gentilTrainer.ActiveMonster.Caracteristics[0].Actual + " / " + gentilTrainer.ActiveMonster.Caracteristics[0].Total;
            FriendlyMonsterEPActual.Content = gentilTrainer.ActiveMonster.Caracteristics[1].Actual + " / " + gentilTrainer.ActiveMonster.Caracteristics[1].Total;

            //Trainer mechantTrainer = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Robot).First().Trainer;
            Trainer mechantTrainer = SavedGames.LoadedCombat.Players[1].Trainer;
            Player mechant = SavedGames.LoadedCombat.Players[1];

            
            EnemyMonster.Content = mechant.Trainer.ActiveMonster.Template.Name;
            
            //EnemyMonsterType.Content = mechantTrainer.ActiveMonster.;
        }



        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseMonsterControl.Visibility = Visibility.Visible;
            ActionGrid.Visibility = Visibility.Collapsed;
        }

    }
}
