using System;
namespace Core.Model
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
