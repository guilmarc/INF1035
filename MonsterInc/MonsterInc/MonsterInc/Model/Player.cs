using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Core.Model
{
    [Serializable]
	public class Player: INotifyPropertyChanged
	{
        string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                PropertyChanged.OnPropertyCHange(this, "Name");
            }
        }

        /// <summary>
        /// L'entraîneur en cours associé au joueur.  Dans une version future, le joueur pourrait sélectionner parmis une liste de Trainers
        /// </summary>
        public Trainer Trainer { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
