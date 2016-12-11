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
    /// Logique d'interaction pour TrainerHome.xaml
    /// </summary>
    public partial class TrainerHome : UserControl
    {
        public TrainerHome()
        {
            InitializeComponent();
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
            DifficultyGrid.Visibility = Visibility.Visible;
            MenuGrid.Visibility = Visibility.Collapsed;
        }

        private void MenuStoreBtn_Click(object sender, RoutedEventArgs e)
        {
            ItemShopGrid.Visibility = Visibility.Visible;
            TrainerHomeGrid.Visibility = Visibility.Collapsed;

        }
    }
}
