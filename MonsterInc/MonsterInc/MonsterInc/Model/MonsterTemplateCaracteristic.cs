﻿using System;
namespace Core.Model
{
	public enum MonsterTemplateCaracteristicType
	{
		LifePoints,
		EnergyPoints,
		RegenerationPoints,
		AttackPoints,
		DefensePoints
	}

    [Serializable]
    public class MonsterTemplateCaracteristic
	{
		//public string Name { get; set; }
		public MonsterTemplateCaracteristicType Type { get; set; }

		public int Base { get; set; }					//Valeur de base de cette caractérsitique

		public int Progression { get; set; }            //Progression du niveau de base à chaque gain de niveau d'expérience
	}
}
