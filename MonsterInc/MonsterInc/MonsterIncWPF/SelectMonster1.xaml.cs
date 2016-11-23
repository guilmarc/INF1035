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
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class SelectMonster1 : UserControl
    {
        private Core.Model.Trainer trainer = new Core.Model.Trainer();
        //private DetailMonster detailWindowOpen;

        public SelectMonster1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                trainer.Affinity = Core.Extensions.ToEnum<Core.Element>(ListAffinity.SelectedValue.ToString());
                trainer.ActiveMonsters = new List<Core.Model.Monster>();
                trainer.ActiveMonsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);

                trainer.Monsters = new List<Core.Model.Monster>();
                trainer.Monsters.Add((Core.Model.Monster)ListSelectTempMonsters.SelectedValue);
            }
            catch (Exception)
            {

                throw;
            }


            Core.Engine.Player.Trainer = trainer;

        }
    }
}
