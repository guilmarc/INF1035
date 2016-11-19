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
    /// Interaction logic for SelectMonster.xaml
    /// </summary>
    public partial class SelectMonster : Window
    {
        private Core.Model.Trainer trainer = new Core.Model.Trainer();
        public SelectMonster()
        {
            InitializeComponent();
            this.DataContext = trainer;

            trainer.SelectTempMonsters = new ObservableCollection<Core.Model.Monster>(Core.Engine.GenerateInitMonsters());
        }
    }
}
