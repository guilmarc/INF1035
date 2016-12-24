using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Core.Model;
using System.Xml.Serialization;
using Core.Exceptions;

namespace Core.Model
{
    /// <summary>
    /// Classe des entraîneurs de monstres
    /// Dans une version future, un joueur pourra avoir plusieurs entraîneurs 
    /// </summary>
    [Serializable]
    public class Trainer : INotifyPropertyChanged
	{
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Constructeur vide nécessaire à la sérialisation
        /// </summary>
        public Trainer(){}

        /// <summary>
        /// Constructeur obligatoire.  Pour créer un trainer, ça prend un nom et un Élément
        /// </summary>
        /// <param name="name"></param>
        /// <param name="element"></param>
	    public Trainer(string name, Element element)
	    {
	        this.Name = name;
	        this.Affinity = element;
	    }

        /// <summary>
        /// Nom de l'entraîneur
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Or possèdé par l'entraîneur
        /// </summary>
        private int _gold = Constants.InitGoldCount;
        public int Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                PropertyChanged.OnPropertyCHange(this, "Gold");
            }
        }

        /// <summary>
        /// Inventaire compler de l'entraîneur
        /// </summary>
        public List<Item> Inventory { get; set; } = new List<Item>();

        /// <summary>
        /// Monstre actuellement au front
        /// </summary>
        public Monster ActiveMonster { get; set; } = null;

        /// <summary>
        /// Liste des monstres capturés
        /// </summary>
        public List<Monster> Monsters { get; set; } = new List<Monster>();

        /// <summary>
        /// Liste des items présenta à la ceinture
        /// </summary>
		public List<Item> ActiveInventory { get; set; } = new List<Item>();

        /// <summary>
        /// Liste des items disponible à ajouter à la ceinture
        /// </summary>
	    public List<Item> AvailableItems {
	        get { return Inventory.Where(x => !ActiveInventory.Contains(x)).ToList(); }
	    }

        /// <summary>
        /// Liste des monstres actuellement prêt pour un futur combat
        /// </summary>
	    public List<Monster> ActiveMonsters { get; set; } = new List<Monster>();

        /// <summary>
        /// Liste des monstres disponibles à ajouter à l'arène
        /// </summary>
	    public List<Monster> AvailableMonsters
	    {
	        get { return Monsters.Where(x => !ActiveMonsters.Contains(x)).ToList(); }
	    }

        /// <summary>
        /// Total des points de vie de tous les monstres dans le combat en cours
        /// </summary>
	    public int LifePoints { get { return GetActualValue(MonsterTemplateCaracteristicType.LifePoints); } }

        /// <summary>
        /// Effectue la somme des valeurs actuelles d'une caractéristique donnée
        /// </summary>
        /// <param _name="type"></param>
        /// <returns>Somme des valeurs Actual</returns>
	    public int GetActualValue(MonsterTemplateCaracteristicType type)
	    {
            return ActiveMonsters.Sum(x => x.GetCaracteristic(type).Actual);
        }

        /// <summary>
        /// Spécialité de l'entraîneur
        /// </summary>
        public Element Affinity { get; set; }

        /// <summary>
        /// Effectuer l'achat d'items
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool BuyItem(Item item)
		{
			if (item.Gold > this.Gold)
			{
				throw new NotEnoughtGoldException(this,item);
			}

            this.Inventory.Add(item);

            if (this.ActiveInventory.Count < Constants.ActiveInventoryCount)
            {
                this.ActiveInventory.Add(item);
            }

		    this.Gold -= item.Gold;
		    return true;
		}

        /// <summary>
        /// Vendre des items
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool SellItem(Item item)
        {
            if (this.Inventory.Remove(item))
            {
                this.ActiveInventory.Remove(item);
                this.Gold += item.Gold;
            }

            return true;
        }

    }
}
