namespace Core
{
    /// <summary>
    /// Contrat à respecter lors de l'implémentation d'une stratérie de sélection de niveau d'expérience
    /// </summary>
    public interface IExperienceLevelStrategy
    {
        int EvaluateExperienceLevel(int newExperiencePoint);
    }
}