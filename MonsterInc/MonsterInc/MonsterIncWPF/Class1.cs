using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterArena
{
    public class BindingToFormExample : INotifyPropertyChanged
    {
        private string firstPropertie = "prop 1 init...";

        public string FirstPropertie
        {
            get
            {
                return firstPropertie;
            }
            set
            {
                firstPropertie = value;
                OnPropertyChanged("FirstPropertie");
            }
        }

        private string secondPropertie = "prop 2 init...";

        public string SecondPropertie
        {
            get
            {
                return secondPropertie;
            }
            set
            {
                secondPropertie = value;
                OnPropertyChanged("SecondPropertie");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }
    }
}
