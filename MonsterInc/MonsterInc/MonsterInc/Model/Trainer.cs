﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MonsterInc;

namespace Core.Model
{
	/// <summary>
	/// Un entraîneur possède une liste de monstres
	/// </summary>
	public class Trainer : INotifyPropertyChanged
	{
	    private const int INIT_GOLD_VALUE = 1000;

        public event PropertyChangedEventHandler PropertyChanged;
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

        public ObservableCollection<Monster> SelectTempMonsters { get; set; }

        public List<Item> Inventory { get; set; }

		public List<Monster> Monsters { get; set; } //Limité à 250

		public List<Item> ActiveInventory { get; set; }

		public List<Monster> ActiveMonsters { get; set; }

		public Element Affinity { get; set; }

		public bool BuyItem(Item item)
		{
			if (item.Gold > this.Gold)
			{
				throw new NotEnoughtGoldException("Vous n'avez assez d'or pour acheter l'item " + item.Name);
			}

            this.Inventory.Add(item);
		    this.Gold -= item.Gold;
		    return true;
		}
	}
}
