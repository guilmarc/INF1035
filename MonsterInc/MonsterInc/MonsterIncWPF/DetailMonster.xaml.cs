﻿using System;
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
using System.Windows.Shapes;

namespace MonsterIncWPF
{
    /// <summary>
    /// Interaction logic for DetailMonster.xaml
    /// </summary>
    public partial class DetailMonster : Window
    {
        private Core.Model.Monster monsterContext = null;
        public DetailMonster(Core.Model.Monster monster)
        {
            this.DataContext = monster;
            InitializeComponent();

        }
    }
}