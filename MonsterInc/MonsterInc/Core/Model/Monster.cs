using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Core.Events;
using Core.Exceptions;

namespace Core.Model
{
    
	//public delegate void ExperienceLevelChangedHandler(Monster m, EventArgs e);
    [Serializable]
	public class Monster
	{
        /// <summary>
        /// Événement déclanché lors d'un changement de niveau d'expérience
        /// </summary>
        public event EventHandler<ExperienceLevelChangedEventArgs> ExperienceLevelChanged;
        
        /// <summary>
        /// Constructeur par défaut nécessaire à la sérialisation 
        /// </summary>
        public Monster() {}

        //[XmlIgnore]
        /// <summary>
        /// Template sur lequel se base ce monstre
        /// </summary>
        public MonsterTemplate Template { get; set; }

        /// <summary>
        /// Numéro unique associé au monstre
        /// </summary>
		public int ID { get; set; }

        /// <summary>
        /// Surnom donné à un monstre
        /// </summary>
	    private string _nickName = null;
	    public string NickName
	    {
	        get { return _nickName ?? Template.Name; }
	        set { _nickName = value; }
	    }

        /// <summary>
        /// Niveau d'expérience du monstre
        /// </summary>
	    public int ExperienceLevel { get; set; }

        /// <summary>
        /// Points d'expériences du monstre
        /// </summary>
		public int ExperiencePoint { get; set; }

        /// <summary>
        /// Caractéristiques du monstre
        /// </summary>
		public List<MonsterCaracteristic> Caracteristics { get; set; } = new List<MonsterCaracteristic>();

        /// <summary>
        /// Liste des skills actuellement disponible par le monstre
        /// </summary>
        [XmlIgnore]
        public List<Skill> ActiveSkills
	    {
	        get { return Universe.Skills.Where(x => this.ExperienceLevel >= x.MinimumExperienceLevel).Where(y => (y.ElementRequirement.Count == 0) || y.ElementRequirement.Contains(this.Template.Element)).ToList();}
	    }

        /// <summary>
        /// État du monstre (vivant ou mort)
        /// </summary>
	    public bool IsAlive
	    {
	        get { return this.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual > 0; }
	    }

        /// <summary>
        /// Méthode retournant si un Usable est présentement accessible par le monstre
        /// </summary>
        /// <param name="usable"></param>
        /// <returns></returns>
	    public bool CanUseUsable(Usable usable)
	    {
	        if (usable is Skill)
	        {
	            return ((Skill) usable).EnergyPointCost <= this.GetCaracteristic(MonsterTemplateCaracteristicType.EnergyPoints).Actual;
	        }
	        return true;
	    }


        /// <summary>
        /// Constructeur obligatoire pour un monstre
        /// </summary>
        /// <param name="id">Numéro unique du monstre à créer</param>
        /// <param name="monsterTemplate">Template de monstre à instancié</param>
        /// <param name="CaracteristicFactor">Augmentation ou diminution des valeurs selon le niveau de difficulté</param>
	    public Monster(int id, MonsterTemplate monsterTemplate, double CaracteristicFactor = 1.0)
		{
			this.Template = monsterTemplate;

			this.ExperienceLevel = monsterTemplate.BaseLevel;

			foreach (var monsterTemplateCaracteristic in monsterTemplate.Caracteristics)
			{
				this.Caracteristics.Add( new MonsterCaracteristic(monsterTemplateCaracteristic, this.ExperienceLevel, CaracteristicFactor) );
			}
		}

        /// <summary>
        /// Réénergiser le monstre actif (tour par tour)
        /// </summary>
	    public void Energize()
        { 
            if(IsAlive)
	        this.GetCaracteristic(MonsterTemplateCaracteristicType.EnergyPoints).Actual += this.GetCaracteristic(MonsterTemplateCaracteristicType.RegenerationPoints).Actual;
	    }

        /// <summary>
        /// Réinitialisation des caractéristiques du monstre à chaque combat
        /// </summary>
	    public void ResetCaracterictics()
	    {
            this.Caracteristics.ForEach(x => x.InitWithLevel(this.ExperienceLevel));
	    }

		/// <summary>
		/// Méthode retournant la caractéristique de monstre tel que demandée  
		/// </summary>
		/// <returns>The caracteristic.</returns>
		/// <param name="type">Type.</param>
		public MonsterCaracteristic GetCaracteristic(MonsterTemplateCaracteristicType type)
		{
			return Caracteristics.FirstOrDefault(c => c.Type == type);
		}

        /// <summary>
        /// Incrémentation des points d'expérience
        /// </summary>
        /// <param name="points"></param>
		public void IncrementExperiencePointBy(int points)
		{
			//On incrémente les points d'expérience selon le nombre de points demandés		                             
			this.ExperiencePoint += points;

			//Utilisation de la stratégie d'augmentation (Strategy Pattern)
			var newExperienceLevel = new BaseExperienceLevelStrategy().EvaluateExperienceLevel(this.ExperiencePoint);

			if (newExperienceLevel != this.ExperienceLevel)
			{
				this.ExperienceLevel = newExperienceLevel;
				OnExperienceLevelChanged(this.ExperienceLevel);	
			}
		}

        /// <summary>
        /// Comportement de l'événement lors du changement de niveau d'expérience
        /// </summary>
        /// <param name="newExperienceLevel"></param>
		protected void OnExperienceLevelChanged(int newExperienceLevel)
        {
            this.Caracteristics.ForEach(x => x.InitWithLevel(newExperienceLevel));
            //Lancement de l'événement
            ExperienceLevelChanged?.Invoke(this, new ExperienceLevelChangedEventArgs(newExperienceLevel));
        }

        /// <summary>
        /// Affichage du monstre
        /// </summary>
        /// <returns></returns>
	    public override string ToString()
	    {
	        return this.NickName;
	    }
	}
}
