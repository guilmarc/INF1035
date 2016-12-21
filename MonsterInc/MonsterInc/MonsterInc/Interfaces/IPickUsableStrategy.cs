using Core.Model;

namespace Core
{
    public interface IPickUsableStrategy
    {
        Usable PickUsable(Player player, Player opponent);
    }
}