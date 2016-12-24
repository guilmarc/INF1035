using System;
namespace Core.Events
{
    /// <summary>
    /// Arguments de l'événement déclanchée lors d'un changement de niveau d'expérience
    /// </summary>
	public class ExperienceLevelChangedEventArgs : EventArgs
	{
		public int NewExperienceLevel { get; set; }

		public ExperienceLevelChangedEventArgs(int newExperienceLevel)
		{
			this.NewExperienceLevel = newExperienceLevel;
		}
	}
}
