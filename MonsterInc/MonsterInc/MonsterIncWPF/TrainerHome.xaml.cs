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
using Core.Model;

namespace MonsterIncWPF
{
    /// <summary>
    /// Logique d'interaction pour TrainerHome.xaml
    /// </summary>
    public partial class TrainerHome : UserControl
    {
        List<Button> listeButtons = new List<Button>();
        List<Label> listeLvl = new List<Label>();
        List<Label> listeType = new List<Label>();
        List<Label> listeLife = new List<Label>();
        List<Label> listeEnergy = new List<Label>();

        public TrainerHome()
        {
            
        }
        public TrainerHome(bool affiche)
        {
            InitializeComponent();
            this.DataContext = SavedGames.LoadedPlayer;
            Trainer trainer = SavedGames.LoadedPlayer.Trainer;
            DifficultyListBox.ItemsSource = DifficultyData.Difficulty;
            InitListes();


            int nbActiveMonster = trainer.ActiveMonsters.Count; 
            for (int i = 0; i < 5; i++)
            {
                if (i<nbActiveMonster)
                {
                    listeButtons[i].Content = trainer.ActiveMonsters[i].NickName + "\n" + trainer.ActiveMonsters[i].Template.Name;
                    listeLvl[i].Content = trainer.ActiveMonsters[i].ExperienceLevel;
                    listeType[i].Content = trainer.ActiveMonsters[i].Template.Element;
                    listeLife[i].Content = trainer.ActiveMonsters[i].Caracteristics[0].Total;
                    listeEnergy[i].Content = trainer.ActiveMonsters[i].Caracteristics[1].Total;
                }
                else
                {
                    listeButtons[i].Content = "<empty>";
                    listeLvl[i].Content = "";
                    listeType[i].Content = "";
                    listeLife[i].Content = "";
                    listeEnergy[i].Content ="";
                }
            }
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
            Combat combat = new Combat(SavedGames.LoadedGame, (Core.Model.Difficulty)DifficultyListBox.SelectedValue);
            
            SavedGames.LoadedCombat = combat;
            ((TrainerHome)t).TrainerHomeGrid.Visibility = Visibility.Collapsed;
            ActiveGrid.Children.Add(new CombatMain { Visibility = Visibility.Visible });
        }


        private void InitListes()
        {
            listeButtons.Add(MonsterBtn1);
            listeButtons.Add(MonsterBtn2);
            listeButtons.Add(MonsterBtn3);
            listeButtons.Add(MonsterBtn4);
            listeButtons.Add(MonsterBtn5);
            listeLvl.Add(MonsterLevelValue1);
            listeLvl.Add(MonsterLevelValue2);
            listeLvl.Add(MonsterLevelValue3);
            listeLvl.Add(MonsterLevelValue4);
            listeLvl.Add(MonsterLevelValue5);
            listeType.Add(MonsterElementValue1);
            listeType.Add(MonsterElementValue2);
            listeType.Add(MonsterElementValue3);
            listeType.Add(MonsterElementValue4);
            listeType.Add(MonsterElementValue5);
            listeLife.Add(MonsterHPValue1);
            listeLife.Add(MonsterHPValue2);
            listeLife.Add(MonsterHPValue3);
            listeLife.Add(MonsterHPValue4);
            listeLife.Add(MonsterHPValue5);
            listeEnergy.Add(MonsterEnergyValue1);
            listeEnergy.Add(MonsterEnergyValue2);
            listeEnergy.Add(MonsterEnergyValue3);
            listeEnergy.Add(MonsterEnergyValue4);
            listeEnergy.Add(MonsterEnergyValue5);
        }

    }



}
