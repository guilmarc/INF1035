using System;
namespace MonsterInc
{
	public class Action
	{
		public Action()
		{
		}

		IActionable _Action { get; set; }
		Monster Monster { get; set; }
	}
}
