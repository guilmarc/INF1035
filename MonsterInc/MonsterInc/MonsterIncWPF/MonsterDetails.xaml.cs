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
    /// Logique d'interaction pour MonsterDetails.xaml
    /// </summary>
    public partial class MonsterDetails : UserControl
    {
        public MonsterDetails()
        {
            InitializeComponent();
            //this.DataContext = trainer;
            //trainer.SelectTempMonsters[ListSelectTempMonsters.SelectedIndex];
            this.DataContext = monster;

        }

        private Core.Model.Monster monster = new Core.Model.Monster();
        private Core.Model.Trainer trainer = new Core.Model.Trainer();


        public Core.Model.Monster Param1 { get; set; }


    }
}
