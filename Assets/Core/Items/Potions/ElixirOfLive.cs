using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;

namespace Assets.Core.Items.Potions
{
    internal class ElixirOfLive : Potion
    {
        static readonly string name = "Elixir of Life";
        static readonly string description = "This potion may be used immediately after a match in which a member of the warband has died. The figure is brought back to life, and may return to action in the very next match.";
        static readonly ItemType itemType = ItemType.ELIXIR_OF_LIFE;
        static readonly EffectType effectType = EffectType.OUT_OF_GAME;
        static readonly int price = 500;

        public ElixirOfLive() : base (
            name, 
            description, 
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure)
        {
            targetFigure.State = FigureState.HEALTHY;
        }
    }
}
