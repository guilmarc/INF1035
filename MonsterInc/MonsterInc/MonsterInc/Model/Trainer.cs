using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using MonsterInc;
using System.Xml.Serialization;
using Core.Exceptions;

namespace Core.Model
{
    /// <summary>
    /// Un entraîneur possède une liste de monstres
    /// </summary>
    [Serializable]
    public class Trainer : INotifyPropertyChanged
	{
	    private const int INIT_GOLD_VALUE = 1000;
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        string name;

        public Trainer()
        {
        }

	    public Trainer(string name, Element element)
	    {
	        this.Name = name;
	        this.Affinity = element;
	    }

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
        int gold = INIT_GOLD_VALUE;

        public int Gold
        {
            get
            {
                return gold;
            }
            set
            {
                gold = value;
                PropertyChanged.OnPropertyCHange(this, "Gold");

            }
        }
        [XmlIgnore]
        public ObservableCollection<Monster> SelectTempMonsters { get; set; }

        public List<Item> Inventory { get; set; } = new List<Item>();

        public Monster ActiveMonster { get; set; } = null;

        public List<Monster> Monsters { get; set; } = new List<Monster>();

		public List<Item> ActiveInventory { get; set; } = new List<Item>();

		public List<Monster> ActiveMonsters { get; set; } = new List<Monster>();

	    public int LifePoints { get { return GetActualValue(MonsterTemplateCaracteristicType.LifePoints); } }

        /// <summary>
        /// Effectue la somme des valeurs actuelles d'une caractéristique donnée
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Somme des valeurs Actual</returns>
	    public int GetActualValue(MonsterTemplateCaracteristicType type)
	    {
            return ActiveMonsters.Sum(x => x.GetCaracteristic(type).Actual);
        }


        Element affinity;

        public Element Affinity
        {
            get
            {
                return affinity;
            }

            set
            {
                affinity = value;
                //PropertyChanged.OnPropertyCHange(this, "Affinity");
            }
        }

        public bool BuyItem(Item item)
		{
			if (item.Gold > this.Gold)
			{
				throw new NotEnoughtGoldException(this,item);
			}

            this.Inventory.Add(item);

            if (this.ActiveInventory.Count < 5)
            {
                this.ActiveInventory.Add(item);
            }

		    this.Gold -= item.Gold;
		    return true;
		}

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
