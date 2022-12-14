using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class ElixirOfLive : Potion
    {
        static readonly string name = "Elixir of Life";
        static readonly string description = "As a Restore Life spell, no casting roll needed";
        static readonly ItemType itemType = ItemType.ELIXIR_OF_LIFE;
        static readonly int price = 500;

        public ElixirOfLive() : base (
            name, 
            description, 
            itemType,
            price)
        { }
    }
}
