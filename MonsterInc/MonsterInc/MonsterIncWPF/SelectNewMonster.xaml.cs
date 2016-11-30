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
    /// Logique d'interaction pour SelectNewMonster.xaml
    /// </summary>
    public partial class SelectNewMonster : UserControl
    {
        public SelectNewMonster()
        {
            InitializeComponent();
            this.DataContext = trainer;

            trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);

            ListAffinity.ItemsSource = Enum<Core.Element>.GetNames();
        }
        private Core.Model.Trainer trainer = new Core.Model.Trainer("Jean", 0);
        //private MonsterDetails detailControlOpen;


        private void ListSelectTempMonsters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterDetails detailControlOpen = new MonsterDetails(trainer.SelectTempMonsters[ListSelectTempMonsters.SelectedIndex]);

            DetailsControl.Content = detailControlOpen;

            DetailsControl.Visibility=Visibility.Visible;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //trainer.Affinity = Core.Extensions.ToEnum<Core.Element>(ListAffinity.SelectedValue.ToString());
                //trainer.ActiveMonsters = new List<Core.Model.Monster>();
                //trainer.ActiveMonsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);

                //trainer.Monsters = new List<Core.Model.Monster>();
                //trainer.Monsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);
            }
            catch (Exception)
            {

                throw;
            }




            //Core.Engine.Trainer = trainer;


        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //DependencyObject parentObject = VisualTreeHelper.GetParent(this);
            ((MainWindow)System.Windows.Application.Current.MainWindow).Home.Visibility = Visibility.Visible;
            this.Visibility=Visibility.Collapsed;
        }
    }
}
