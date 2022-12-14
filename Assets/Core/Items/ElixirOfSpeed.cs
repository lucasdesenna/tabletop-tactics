using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class ElixirOfSpeed : Potion
    {
        static readonly string name = "Elixir of Speed";
        static readonly string description = "+1 Move for the rest of the game";
        static readonly ItemType itemType = ItemType.ELIXIR_OF_SPEED;
        static readonly int price = 50;

        public ElixirOfSpeed() : base(
            name,
            description,
            itemType,
            price)
        { }
    }
}
