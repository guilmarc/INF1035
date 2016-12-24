using Core.Model;

namespace Core
{
    /// <summary>
    /// Contrat à respecter lors de l'implémentation d'une stratégie de sélection de Usable
    /// </summary>
    public interface IPickUsableStrategy
    {
        Usable PickUsable(Player player, Player opponent);
    }
}