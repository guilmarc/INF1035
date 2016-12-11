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
            //Application.Current.MainWindow = ;
            InitializeComponent();
            this.DataContext = SavedGames.LoadedPlayer;
            BuyItemsListBox.ItemsSource = Core.Universe.Items;
            SellItemsListBox.ItemsSource = SavedGames.LoadedPlayer.Trainer.Inventory;

        }

        private void SellButton_Checked(object sender, RoutedEventArgs e)
        {
            if (SellingButton !=null||ConfirmButton !=null) 
            {
                SellingButton.Visibility = Visibility.Visible;
                ConfirmButton.Visibility = Visibility.Collapsed;
            }


            BuyItemsListBox.Visibility = Visibility.Collapsed;
            SellItemsListBox.Visibility = Visibility.Visible;
        }

        private void BuyButton_Checked(object sender, RoutedEventArgs e)
        {
            if (SellingButton != null || ConfirmButton != null)
            {
                ConfirmButton.Visibility = Visibility.Visible;
                SellingButton.Visibility = Visibility.Collapsed;
            }
            SellItemsListBox.Visibility = Visibility.Collapsed;
            BuyItemsListBox.Visibility = Visibility.Visible;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            ((MainWindow)System.Windows.Application.Current.MainWindow).TrainerHome.TrainerHomeGrid.Visibility = Visibility.Visible;
        }

        private void BuyItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t =  (sender as ListBox).SelectedItem as Item;
            ListCart.Items.Add(t);

            int total = UpdateTotal();
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


        private void button_Click(object sender, RoutedEventArgs e)
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
                int Maxvalue=0;
                foreach (Item item in ListCart.Items)
                {
                    SavedGames.LoadedPlayer.Trainer.BuyItem(item);
                    Maxvalue++;
                }
            }
            catch (Core.Exceptions.NotEnoughtGoldException ex)
            {
                ExWindow winError = new ExWindow(ex);
                winError.Show();
            }
            ListCart.Items.Clear();
            UpdateTotal();
        }

        private void SellingButton_Click(object sender, RoutedEventArgs e)
        {
            //int totalRefunds = 0;
            foreach (Item item in SellItemsListBox.SelectedItems)
            {
                SavedGames.LoadedPlayer.Trainer.SellItem(item);
            }
            SellItemsListBox.ItemsSource =null;
            SellItemsListBox.ItemsSource = SavedGames.LoadedPlayer.Trainer.Inventory;
            //SavedGames.LoadedPlayer.ActiveTrainer.Gold += totalRefunds;

        }
    }
}
