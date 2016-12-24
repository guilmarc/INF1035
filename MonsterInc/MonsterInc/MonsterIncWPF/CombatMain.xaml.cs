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
        Trainer gentilTrainer = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Human).First().Trainer;
        Trainer mechantTrainer = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Robot).First().Trainer;
        Player currentPlayer = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Human).First();
        Player ennemyPlayer = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Robot).First();
        public CombatMain()
        {
            InitializeComponent();
            this.DataContext = SavedGames.LoadedCombat;
            Refresh();
            AttackList.DataContext = gentilTrainer.ActiveMonster;
            ItemList.DataContext = gentilTrainer;
            CombatTextBlock.Text = "Start! \n";
        }

        public void Refresh()
        {
            FriendlyMonster.Content = gentilTrainer.ActiveMonster.NickName;
            FriendlyMonsterType.Content = gentilTrainer.ActiveMonster.Template.Name + " - Level : " + gentilTrainer.ActiveMonster.ExperienceLevel;
            FriendlyMonsterLPActual.Content = gentilTrainer.ActiveMonster.Caracteristics[0].Actual + " / " + gentilTrainer.ActiveMonster.Caracteristics[0].Total;
            FriendlyMonsterEPActual.Content = gentilTrainer.ActiveMonster.Caracteristics[1].Actual + " / " + gentilTrainer.ActiveMonster.Caracteristics[1].Total;


            EnemyMonster.Content = mechantTrainer.ActiveMonster.Template.Name;
            EnemyMonsterType.Content = "Level : " + mechantTrainer.ActiveMonster.ExperienceLevel;
            EnemyMonsterLPActual.Content = mechantTrainer.ActiveMonster.Caracteristics[0].Actual + " / " + mechantTrainer.ActiveMonster.Caracteristics[0].Total;
            EnemyMonsterEPActual.Content = mechantTrainer.ActiveMonster.Caracteristics[1].Actual + " / " + mechantTrainer.ActiveMonster.Caracteristics[1].Total;

            
        }

        private void DeleteChooseMonsterControl()
        {
            ChangeMonsterGrid.Children.Clear();
        }

        bool isChecked = false;
        private void ChangeButton_Checked(object sender, RoutedEventArgs e)
        {
            OpenMonsterChooser();
        }

        private void OpenMonsterChooser()
        {
            DeleteChooseMonsterControl();
            Control controlChooseMonster = (new ActiveMonster() { Visibility = Visibility.Visible, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = new Thickness(0, -10, 0, 0), Height = 200, Width = 550 });
            ChangeMonsterGrid.Children.Add(controlChooseMonster);
            ItemList.Visibility = Visibility.Collapsed;
            isChecked = true;
        }

        private void AttackButton_Checked(object sender, RoutedEventArgs e)
        {
            AttackList.ItemsSource = null;
            AttackList.ItemsSource = gentilTrainer.ActiveMonster.ActiveSkills;
            AttackList.UpdateLayout();
            AttackList.Visibility = Visibility.Visible;
            isChecked = true;
        }

        private void DefendButton_Checked(object sender, RoutedEventArgs e)
        {
            DoDefense();
        }

        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            if (DefendButton.IsChecked == true && !isChecked)
            {
                DefendButton.IsChecked = false;
                AttackList.Visibility = Visibility.Collapsed;
            }
            else
            {
                DefendButton.IsChecked = true;
                AttackList.Visibility = Visibility.Collapsed;
                isChecked = false;
            }
            Refresh();
        }

        private void ItemsButton_Checked(object sender, RoutedEventArgs e)
        {
            ItemList.Visibility=Visibility.Visible;
            ItemList.UpdateLayout();
            isChecked = true;
        }



        private void AttackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (AttackButton.IsChecked == true && !isChecked)
            {
                AttackButton.IsChecked = false;
                AttackList.Visibility = Visibility.Collapsed;
                Refresh();
            }
            else
            {
                AttackButton.IsChecked = true;
                isChecked = false;
            }
        }


        private void ItemsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (ItemsButton.IsChecked == true && !isChecked)
            {
                ItemsButton.IsChecked = false;
                DeleteChooseMonsterControl();
                ItemList.Visibility = Visibility.Collapsed;
            }
            else
            {
                DeleteChooseMonsterControl();
                ItemsButton.IsChecked = true;
                isChecked = false;
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeButton.IsChecked == true && !isChecked)
            {
                ChangeButton.IsChecked = false;
                ItemList.Visibility = Visibility.Collapsed;
                DeleteChooseMonsterControl();
                Refresh();
            }
            else
            {
                ChangeButton.IsChecked = true;
                isChecked = false;
            }
        }

        private void DoAction(Usable usable)
        {
            Turn tour = new Turn(currentPlayer, ennemyPlayer, SavedGames.LoadedCombat, usable);

            tour.MonsterDefeated += (o, args) =>
            {
                MessageBox.Show("Monster " + args.DefeatedMonsterPlayer.ActiveTrainer.ActiveMonster + " is dead !");
                if (args.DefeatedMonsterPlayer.Type == PlayerType.Human)
                {
                    OpenMonsterChooser();
                }
            };

            string tourFait = tour.Run();

            CombatTextBlock.Text += tourFait;
            Refresh();
            CombatTextScroll.UpdateLayout();
            CombatTextScroll.ScrollToVerticalOffset(double.MaxValue);

            CheckWin();
        }

        private void DoAttack(object sender, SelectionChangedEventArgs e)
        {
            if (AttackList.SelectedIndex != -1)
            {
                DoAction(gentilTrainer.ActiveMonster.ActiveSkills[AttackList.SelectedIndex]);

                //cache liste d'attaque
                AttackButton.IsChecked = false;
                AttackList.UnselectAll();
                AttackList.Visibility = Visibility.Collapsed;
            }
        }

        private void DoDefense()
        {
            DoAction(null);

            //cache liste d'attaque
            AttackButton.IsChecked = false;
            AttackList.UnselectAll();
            AttackList.Visibility = Visibility.Collapsed;

        }

        private void ConsumeItem(object sender, SelectionChangedEventArgs e)
        {
            if (ItemList.SelectedIndex != -1)
            {
                DoAction(gentilTrainer.ActiveInventory[ItemList.SelectedIndex]);

                //cache liste d'items
                ItemsButton.IsChecked = false;
                ItemList.UnselectAll();
                ItemList.Visibility = Visibility.Collapsed;
            }
        }

        private void CheckWin()
        {
            if (mechantTrainer.ActiveMonster.Caracteristics[0].Actual == 0 || SavedGames.LoadedCombat.Tour >= 500)
            {
                CombatTextBlock.Text += "YOU WON!\n";
                Reward reward = new Reward(SavedGames.LoadedCombat);
                string textReward = reward.AssignReward();
                CombatTextBlock.Text += textReward;
                PreQuit();
            }
            else if (gentilTrainer.ActiveMonster.Caracteristics[0].Actual == 0)
            {
                CombatTextBlock.Text += "YOU LOST! :'( \n";
                PreQuit();
            }
        }

        private void PreQuit()
        {
            ActionGrid.Visibility = Visibility.Collapsed;
            QuitCombatGrid.Visibility = Visibility.Visible;
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            currentPlayer.ResetActiveTrainer();
            var t = SavedGames.mainWindow.AppGrid.Children[SavedGames.trainerHomeForm];
            ((TrainerHome)t).TrainerHomeGrid.Visibility = Visibility.Visible;
            ((TrainerHome)t).HideDifficulty();
            ((TrainerHome)t).TrainerHomeRefresh();
        }
    }
}
