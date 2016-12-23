using System;
namespace Core.Events
{
	public class ExperienceLevelChangedEventArgs : EventArgs
	{
		public int NewExperienceLevel { get; set; }

		public ExperienceLevelChangedEventArgs(int newExperienceLevel)
		{
			this.NewExperienceLevel = newExperienceLevel;
		}
	}
}
