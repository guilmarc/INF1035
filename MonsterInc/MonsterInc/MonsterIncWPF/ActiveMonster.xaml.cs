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
    /// Interaction logic for ActiveMonster.xaml
    /// </summary>
    public partial class ActiveMonster : UserControl
    {
        List<Button> listeButtons = new List<Button>();
        List<Label> listeLvl = new List<Label>();
        List<Label> listeType = new List<Label>();
        List<Label> listeLife = new List<Label>();
        List<Label> listeEnergy = new List<Label>();
        Trainer trainer = SavedGames.LoadedGame.HumanPlayer.Trainer;

        public ActiveMonster()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                return;
            }
            InitListes();

            int nbActiveMonster = trainer.ActiveMonsters.Count;
            for (int i = 0; i < 5; i++)
            {
                if (i < nbActiveMonster)
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
                    listeEnergy[i].Content = "";
                }
            }

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

        private void Hide()
        {
            this.Visibility=Visibility.Collapsed;
        }


        private void MonsterBtn1_Click(object sender, RoutedEventArgs e)
        {
            ActiveMonsterChange(0);
        }
        private void MonsterBtn2_Click(object sender, RoutedEventArgs e)
        {
            ActiveMonsterChange(1);
        }
        private void MonsterBtn3_Click(object sender, RoutedEventArgs e)
        {
            ActiveMonsterChange(2);
        }
        private void MonsterBtn4_Click(object sender, RoutedEventArgs e)
        {
            ActiveMonsterChange(3);
        }
        private void MonsterBtn5_Click(object sender, RoutedEventArgs e)
        {
            ActiveMonsterChange(4);
        }

        private void ActiveMonsterChange(int choix)
        {
            if (choix < trainer.ActiveMonsters.Count)
            {
                trainer.ActiveMonster = trainer.ActiveMonsters[choix];
                Hide();
            }    
        }
    }
}
