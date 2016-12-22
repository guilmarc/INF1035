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
    /// Interaction logic for ItemsForm.xaml
    /// </summary>
    public partial class ItemsForm : UserControl
    {
        public ItemsForm()
        {
            InitializeComponent();

            //ActiveItemsListBox

            this.DataContext = SavedGames.LoadedPlayer;
            ActiveItemsListBox.ItemsSource = SavedGames.LoadedPlayer.ActiveTrainer.ActiveInventory;
            ItemsListBox.ItemsSource = Core.Universe.Items;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var t = SavedGames.mainWindow.AppGrid.Children[SavedGames.trainerHomeForm];
            ((TrainerHome)t).TrainerHomeGrid.Visibility = Visibility.Visible;
        }
    }
}
