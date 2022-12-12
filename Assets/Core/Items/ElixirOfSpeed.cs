using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class ElixirOfSpeed : Potion
    {
        static readonly string name = "Elixir of Speed";
        static readonly string description = "+1 Move for the rest of the game";
        static readonly int value = 50;

        public ElixirOfSpeed() : base(
            ElixirOfSpeed.name,
            ElixirOfSpeed.description,
            ItemType.ELIXIR_OF_SPEED,
            ElixirOfSpeed.value)
        { }
    }
}
