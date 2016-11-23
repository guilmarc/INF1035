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
using Core;

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Core.Model.Player player = new Core.Model.Player();
        private Core.Model.Trainer trainer = new Core.Model.Trainer();
        private DetailMonster detailWindowOpen = null;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = player;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Player = player;

            //SelectMonster win2 = new SelectMonster();
            //win2.Show();
            //this.Close();
            GridStart.Visibility = Visibility.Hidden;
            //trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Engine.InitMonsters);
            this.DataContext = trainer;
            GridSelectMonster.Visibility = Visibility.Visible;
        }

        public void SelectMonster()
        {
            //InitializeComponent();
            //this.DataContext = trainer;

            //trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Engine.InitMonsters);
            //ListSelectTempMonsters.ItemsSource = trainer.SelectTempMonsters;
        }

        private void ListSelectTempMonsters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            detailWindowOpen?.Close();
            detailWindowOpen = new DetailMonster(trainer.SelectTempMonsters[ListSelectTempMonsters.SelectedIndex]);
            detailWindowOpen.Show();
        }
    }
}
