using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for SelectMonster.xaml   NE PLUS SE SERVIR DE CE FICHIER
    /// </summary>
    public partial class SelectMonster : Window
    {
        private Core.Model.Trainer trainer = new Core.Model.Trainer("Jean", 0);
        private DetailMonster detailWindowOpen;

        public SelectMonster()
        {
            InitializeComponent();
            this.DataContext = trainer;

            trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);

            ListAffinity.ItemsSource = Enum<Core.Element>.GetNames();

            
            //ListSelectTempMonsters.ItemsSource = trainer.SelectTempMonsters;
        }

        private void ListSelectTempMonsters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //detailWindowOpen?.Close();

            //detailWindowOpen = new DetailMonster(trainer.SelectTempMonsters[ListSelectTempMonsters.SelectedIndex]);
            //detailWindowOpen.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
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




            Core.Engine.Player.Trainer = trainer;


        }
    }
}
