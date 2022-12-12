using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class ElixirOfLive : Potion
    {
        static readonly string name = "Elixir of Life";
        static readonly string description = "As a Restore Life spell, no casting roll needed";
        static readonly int value = 500;

        public ElixirOfLive() : base (
            ElixirOfLive.name, 
            ElixirOfLive.description, 
            ItemType.ELIXIR_OF_LIFE,
            ElixirOfLive.value) { }
    }
}
