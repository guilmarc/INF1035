using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Core.Model
{
    /// <summary>
    /// Type de joueur, humain ou robot ?
    /// </summary>
    public enum PlayerType
    {
        Human,
        Robot
    }

    /// <summary>
    /// Classe des joueurs
    /// </summary>
    [Serializable]
    public class Player : INotifyPropertyChanged
    {
        /// <summary>
        /// Type de joueur, humain ou robot
        /// </summary>
        public PlayerType Type { get; set; }

        /// <summary>
        /// Nom du joueur
        /// </summary>
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                PropertyChanged.OnPropertyCHange(this, "Name");
            }
        }

        /// <summary>
        /// Dans une version future, le joueur pourrait sélectionner parmis une liste de Trainers
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

        /// <summary>
        /// Constructeur par défaut obligatoire à la sérialisation
        /// </summary>
        public Player() {}

        /// <summary>
        /// Constructeur servant à instancié un joueur humain avec un nom
        /// </summary>
        /// <param name="name"></param>
        public Player(string name):this(name,PlayerType.Human)
        {
            
        }

        /// <summary>
        /// Constructeur servant à instancié un joueur selon le type et le nom
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public Player(string name, PlayerType type)
        {
            this._name = name;
            this.Type = type;
        }

        /// <summary>
        /// Mise à jour des caractéristiques de tous les monstres actifs
        /// </summary>
        public void ResetActiveTrainer()
        {
            this.ActiveTrainer.ActiveMonsters.ForEach(x => x.ResetCaracterictics());
        }

        /// <summary>
        /// Sélection du Usable requis selon le niveau d'intelligence implémenté
        /// </summary>
        /// <param name="opponent"></param>
        /// <returns></returns>
        public Usable PickUsable(Player opponent)
        {
            //TODO: Changer la stratégie de base pour la stratégie intelligente (après le cours d'intelligence artificielle)
            return new BasicPickUsableStrategy().PickUsable(this, opponent);
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Affichage du joueur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name + " LP=" + this.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual;
        }

    }
}