using System;
namespace Core.Model
{
	public class MonsterCaracteristic
	{
		readonly MonsterTemplateCaracteristic _monsterTemplateCaracteristic;

		public MonsterTemplateCaracteristicType Type { get { return _monsterTemplateCaracteristic.Type; } } 
		public int Total { get; private set; }

		public int Actual { get; set; }

		public MonsterCaracteristic(MonsterTemplateCaracteristic monsterTemplateCaracteristic)
		{
			this._monsterTemplateCaracteristic = monsterTemplateCaracteristic;
		}

		public void InitWithLevel(int experienceLevel)
		{
			UpdateWithLevel(experienceLevel);
			this.Actual = Total;
		}

		public void UpdateWithLevel(int experienceLevel)
		{
			this.Total = this._monsterTemplateCaracteristic.Base + (this._monsterTemplateCaracteristic.Progression * experienceLevel);
		}
	}
}
