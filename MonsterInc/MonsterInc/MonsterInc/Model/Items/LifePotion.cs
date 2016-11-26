using System;
using System.Linq;

namespace Core.Model
{

	/// <summary>
	/// Item qui ajoute des points de vie
	/// </summary>
	public class LifePotion : Item
	{
        public override void Consume(Trainer trainer)
        {
            var carac = trainer.ActiveMonster.Caracteristics.Where(c => c.Type == MonsterTemplateCaracteristicType.LifePoints).Single();


            EffectScope scope = this.Scopes.OfType<EffectScope>().First();

            //monstre a 100 de vie et une potion qui heal de 15% (0.15) = + 15pv
            double lifeAdded =carac.Base *scope.Magnitude;
            int roundedLifeAdded = int.Parse(lifeAdded.ToString());
            //subit des dégats/ met le monstre a 1 life 
            carac.Actual = 1;

            carac.Actual = carac.Actual + roundedLifeAdded;


        }
    }

}