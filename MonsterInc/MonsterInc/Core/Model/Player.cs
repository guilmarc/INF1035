using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Core.Model
{

    public enum PlayerType
    {
        Human,
        Robot
    }

    [Serializable]
    public class Player : INotifyPropertyChanged
    {
        public PlayerType Type { get; set; }

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

        /// <summary>
        /// L'entraîneur actif associé à ce joueur
        /// </summary>
        /// En programmant ainsi, il sera facile dans le futur d'implémenter le multi-entraîneur
	    public Trainer ActiveTrainer
        {
            get { return Trainer; }
        }

        public Player()
        {
            
        }
        public Player(string name):this(name,PlayerType.Human)
        {
            
        }
        public Player(string name, PlayerType type)
        {
            this.name = name;
            this.Type = type;
        }

        public void ResetActiveTrainer()
        {
            foreach (Monster monstre in ActiveTrainer.ActiveMonsters)
                monstre.ResetCaracterictics();
            //ActiveTrainer.
        }

        public Usable PickUsable(Player opponent)
        {
            //TODO: Changer la stratégie de base pour la stratégie intelligente (après le cours d'intelligence artificielle)
            return new BasicPickUsableStrategy().PickUsable(this, opponent);
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return this.Name + " LP=" + this.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual;
        }

    }
}