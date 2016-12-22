using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Core.Model
{
    [Serializable]
	public class Skill : Usable
	{
		public int EnergyPointCost { get; set; }

		public int MinimumExperienceLevel { get; set; }

	    public Element Element { get; set; }

        public List<Element> ElementRequirement { get; set; } = new List<Element>(); // OK si un des éléments est dans la liste, et OK si liste vide

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
                    impact = (int)((damageScope.Magnitude + hit) * elementRatio * Utils.HumanizeRatio());
                }
                if (scope is EffectScope)
                {
                    var effectScope = scope as EffectScope;
                    var impactRatio = effectScope.Magnitude * elementRatio * Utils.HumanizeRatio();
                    var actual = opponent.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual;
                    impact = ((int)(actual * impactRatio)) + hit; 
                }

                target.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual -= impact;

            }

            //TODO: Ici on pourrait creer un objet d'impact et le retourner à l'interface par delegate ou event

            //Diminue l'énergie du monstre selon l'énergie nécessaire à l'utilisation de ce Skill
            player.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.EnergyPoints).Actual -= EnergyPointCost;

        }
	}
}
