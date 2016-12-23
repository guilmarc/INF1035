﻿using System;
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
        Player gentil = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Human).First();
        Player mechant = SavedGames.LoadedCombat.Players.Where(x => x.Type == PlayerType.Robot).First();
        public CombatMain()
        {
            InitializeComponent();
            this.DataContext = SavedGames.LoadedCombat;
            Refresh();
            AttackList.DataContext = gentilTrainer.ActiveMonster;

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
            DeleteChooseMonsterControl();
            Control controlChooseMonster = (new ActiveMonster() { Visibility = Visibility.Visible, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = new Thickness(0, -10, 0, 0), Height = 200, Width = 550 });
            ChangeMonsterGrid.Children.Add(controlChooseMonster);

            isChecked = true;
        }


        private void AttackButton_Checked(object sender, RoutedEventArgs e)
        {
            AttackList.Visibility = Visibility.Visible;
            isChecked = true;
        }

        private void DefendButton_Checked(object sender, RoutedEventArgs e)
        {
            gentilTrainer.ActiveMonster.ActiveSkills[0].Consume(gentil, mechant);
            isChecked = true;
            Refresh();
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
                DeleteChooseMonsterControl();
                Refresh();
            }
            else
            {
                ChangeButton.IsChecked = true;
                isChecked = false;
            }
        }



    }
}
