using System;
namespace Core.Model
{
	public class ExperienceLevelChangedEventArgs : EventArgs
	{
		public int NewExperienceLevel { get; set; }

		//public ExperienceLevelChangedEventArgs(int newExperienceLevel)
		//{
		//	this.NewExperienceLevel = newExperienceLevel;
		//}
	}
}
