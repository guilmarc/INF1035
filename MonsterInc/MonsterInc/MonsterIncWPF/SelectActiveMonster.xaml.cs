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
    /// Interaction logic for SelectActiveMonster.xaml
    /// </summary>
    public partial class SelectActiveMonster : UserControl
    {
        private Core.Model.Trainer trainer = new Core.Model.Trainer("Jean", 0);
        public SelectActiveMonster()
        {
            InitializeComponent();
            this.DataContext = trainer;

            trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Universe.InitMonsters);
        }

        private void MonsterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterDetails detailControlOpen = new MonsterDetails(trainer.SelectTempMonsters[MonsterListBox.SelectedIndex]);

            MonsterDetailsControl.Content = detailControlOpen;

            MonsterDetailsControl.Visibility = Visibility.Visible;
        }
    }
}
