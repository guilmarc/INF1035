using Core.Model;
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

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for ItemShop.xaml
    /// </summary>
    public partial class ItemShop : UserControl
    {
        public ItemShop()
        {
            InitializeComponent();
            this.DataContext = SavedGames.LoadedGame.HumanPlayer;
            BuyItemsListBox.ItemsSource = Core.Universe.Items;
            SellItemsListBox.ItemsSource = SavedGames.LoadedGame.HumanPlayer.Trainer.Inventory;
            BuyButton.IsChecked = true;
        }

        private void SellButton_Checked(object sender, RoutedEventArgs e)
        {
            SellingGrid.UpdateLayout();
            BuyingGrid.Visibility = Visibility.Hidden;
            SellingGrid.Visibility = Visibility.Visible;
        }

        private void BuyButton_Checked(object sender, RoutedEventArgs e)
        {
            SellingListGrid.Children.Clear();
            BuyingGrid.Visibility = Visibility.Visible;
            SellingGrid.Visibility = Visibility.Hidden;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var t = SavedGames.mainWindow.AppGrid.Children[SavedGames.trainerHomeForm];
            ((TrainerHome)t).TrainerHomeGrid.Visibility = Visibility.Visible;
            ((TrainerHome)t).TrainerHomeRefresh();
        }

        private void BuyItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BuyItemsListBox.SelectedIndex != -1)
            {
                var t = (sender as ListBox).SelectedItem as Item;
                ListCart.Items.Add(t);
                int total = UpdateTotal();
                BuyItemsListBox.UnselectAll();
            }

        }


        private int UpdateTotal()
        {
            int totalCost = 0;
            foreach (Item i in ListCart.Items)
            {
                totalCost += i.Gold;
            }
            TotalLabelValue.Content = totalCost.ToString();
            TotalLabel.Content = totalCost.ToString();
            return totalCost;

        }


        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListCart.Items.RemoveAt(ListCart.SelectedIndex);
                int total = UpdateTotal();
            }
            catch (Exception)
            {

            }


        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            int total = UpdateTotal();
            try
            {
                int Maxvalue = 0;
                foreach (Item item in ListCart.Items)
                {
                    SavedGames.LoadedGame.HumanPlayer.Trainer.BuyItem(item);
                    Maxvalue++;
                }
            }
            catch (Core.Exceptions.NotEnoughtGoldException)
            {
                MessageBox.Show("Not enough gold to buy all items in cart");
            }
            ListCart.Items.Clear();
            UpdateTotal();
            this.Visibility = Visibility.Hidden;
            var t = SavedGames.mainWindow.AppGrid.Children[SavedGames.trainerHomeForm];
            ((TrainerHome)t).ActiveGrid.Children.Clear();
            ((TrainerHome)t).ActiveGrid.Children.Add(new ItemShop() { Visibility = Visibility.Visible });
        }

        private void SellingButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Item item in SellItemsListBox.SelectedItems)
            {
                SavedGames.LoadedGame.HumanPlayer.Trainer.SellItem(item);
            }
            SellItemsListBox.ItemsSource = null;
            SellItemsListBox.ItemsSource = SavedGames.LoadedGame.HumanPlayer.Trainer.Inventory;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ListCart.Items.Clear();
            UpdateTotal();
        }
    }
}
