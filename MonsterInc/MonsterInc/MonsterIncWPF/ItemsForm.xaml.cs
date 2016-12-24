using Core.Model;
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

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for ItemsForm.xaml
    /// </summary>
    public partial class ItemsForm : UserControl
    {
        private ObservableCollection<Item> ActiveInventory;

        private ObservableCollection<Item> Inventory;
        private Player player = SavedGames.LoadedGame.HumanPlayer;
        public ItemsForm()
        {
            InitializeComponent();
            //ActiveItemsListBox
            this.DataContext = SavedGames.LoadedGame.HumanPlayer;

            ActiveInventory = new ObservableCollection<Item>
                (SavedGames.LoadedGame.HumanPlayer.ActiveTrainer.ActiveInventory);
            ActiveItemsListBox.ItemsSource = ActiveInventory;

            Inventory = new ObservableCollection<Item>
                (SavedGames.LoadedGame.HumanPlayer.ActiveTrainer.Inventory);
            ItemsListBox.ItemsSource = Inventory;



        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var t = SavedGames.mainWindow.AppGrid.Children[SavedGames.trainerHomeForm];
            ((TrainerHome)t).TrainerHomeGrid.Visibility = Visibility.Visible;
            ((TrainerHome)t).TrainerHomeRefresh();
        }

        private void btnItemToActive_Click(object sender, RoutedEventArgs e)
        {
            if (ActiveInventory.Count < 5 && ItemsListBox.SelectedIndex != -1)
            {
                //Item selectedItem = (Item)ItemsListBox.SelectedItem;
                ActiveInventory.Add((Item)ItemsListBox.SelectedItem);
                player.ActiveTrainer.ActiveInventory.Add((Item)ItemsListBox.SelectedItem);
                player.ActiveTrainer.Inventory.Remove((Item)ItemsListBox.SelectedItem);
                Inventory.RemoveAt(ItemsListBox.SelectedIndex);

                //saveToCurrentGame();
            }

        }


        private void btnActiveToItem_Click(object sender, RoutedEventArgs e)
        {
            //Item selectedItem = (Item)ActiveItemsListBox.SelectedItem;
           if ( ActiveItemsListBox.SelectedIndex != -1 )
            {
                Inventory.Add((Item)ActiveItemsListBox.SelectedItem);
                ActiveInventory.RemoveAt(ActiveItemsListBox.SelectedIndex);

                saveToCurrentGame();
            }

        }

        private void saveToCurrentGame()
        {
            SavedGames.LoadedGame.HumanPlayer.ActiveTrainer.ActiveInventory.Clear();
            foreach (Item item in ActiveInventory)
            {
                SavedGames.LoadedGame.HumanPlayer.ActiveTrainer.ActiveInventory.Add(item);
            }

            SavedGames.LoadedGame.HumanPlayer.ActiveTrainer.Inventory.Clear();
            foreach (Item item in Inventory)
            {
                SavedGames.LoadedGame.HumanPlayer.ActiveTrainer.Inventory.Add(item);
            }

            SavedGames.LoadedGame.Save();
        }
    }
}
