namespace Core
{
    /// <summary>
    /// Stratégie de base pour la sélection du niveau d'expérience
    /// </summary>
    public class BaseExperienceLevelStrategy : IExperienceLevelStrategy
    {

        public int EvaluateExperienceLevel(int newExperiencePoint)
        {
            if (newExperiencePoint < 250) return ((newExperiencePoint / 25) + 1); //1 à 10
            if (newExperiencePoint < 1000) return ((newExperiencePoint / 50) + 6); //11 à 25
            if (newExperiencePoint < 5000) return ((newExperiencePoint / 200) + 21); //26 à 45 
            if (newExperiencePoint < 20000) return ((newExperiencePoint / 400) + 34); // 46 à 83
            if (newExperiencePoint < 32800) return ((newExperiencePoint / 800) + 59); // 84 à 99
            return 100;
        }
    }
}