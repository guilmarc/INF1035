namespace Core.Model
{
    public interface IPickUsableStrategy
    {
        Usable PickUsable(Player player, Player opponent);
    }
}