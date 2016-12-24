using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Core.Model
{
    /// <summary>
    /// Représente une habilité d'une monstre
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(Item))]
    [XmlInclude(typeof(Skill))]
    public class Skill : Usable
	{
        /// <summary>
        /// Coût d'utilisation en points d'énergie
        /// </summary>
		public int EnergyPointCost { get; set; }

        /// <summary>
        /// Niveau d'expérience minimal à son utilisation
        /// </summary>
		public int MinimumExperienceLevel { get; set; }

        /// <summary>
        /// Élément lié à cette habilité
        /// </summary>
	    public Element Element { get; set; }

        /// <summary>
        /// Éléments requis pour pouvoir utiser cette habilité
        /// </summary>
        public List<Element> ElementRequirement { get; set; } = new List<Element>(); // OK si un des éléments est dans la liste, et OK si liste vide

        /// <summary>
        /// Utilisation de l'habilité
        /// </summary>
        /// <param name="player"></param>
        /// <param name="opponent"></param>
        public override void Consume(Player player, Player opponent)
        {
            foreach (var scope in Scopes)
            {
                var target = scope.Target == Scope.ScopeTarget.Self ? player : opponent;

                int playerElementID = (int)player.ActiveTrainer.ActiveMonster.Template.Element;
                int opponentElementID = (int)target.ActiveTrainer.ActiveMonster.Template.Element;

                float elementRatio = Universe.ElementMatrix[playerElementID, opponentElementID] / 100f;
                int attack = player.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.AttackPoints).Actual;
                int defence = target.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.DefensePoints).Actual;
                int hit = attack - defence;

                int impact = 0;
                if (scope is DamageScope)
                {
                    var damageScope = scope as DamageScope;
                    var strenghtDiff = 
                    impact = (int)((damageScope.Magnitude + hit) * elementRatio * Utils.HumanizeRatio())/5;
                }
                if (scope is EffectScope)
                {
                    var effectScope = scope as EffectScope;
                    var impactRatio = effectScope.Magnitude * elementRatio * Utils.HumanizeRatio();
                    var actual = opponent.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual;
                    impact = ((int)(actual * impactRatio)) + hit; 
                }

                target.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual -= impact;

                player.ActiveTrainer.ActiveMonster.IncrementExperiencePointBy(impact / 10);
            }

            //TODO: Ici on pourrait creer un objet d'impact et le retourner à l'interface par delegate ou event

            //Diminue l'énergie du monstre selon l'énergie nécessaire à l'utilisation de ce Skill
            player.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.EnergyPoints).Actual -= EnergyPointCost;

        }
	}
}
