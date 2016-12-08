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
        }

        private void SellButton_Checked(object sender, RoutedEventArgs e)
        {
            BuyItemsListBox.Visibility = Visibility.Collapsed;
            SellItemsListBox.Visibility = Visibility.Visible;
        }

        private void BuyButton_Checked(object sender, RoutedEventArgs e)
        {
            SellItemsListBox.Visibility = Visibility.Collapsed;
            BuyItemsListBox.Visibility = Visibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            ((MainWindow)System.Windows.Application.Current.MainWindow).TrainerHome.TrainerHomeGrid.Visibility = Visibility.Visible;
        }
    }
}
