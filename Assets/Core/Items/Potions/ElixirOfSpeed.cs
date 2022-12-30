using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System;

namespace Assets.Core.Items.Potions
{
    internal class ElixirOfSpeed : Potion
    {
        static readonly string name = "Elixir of Speed";
        static readonly string description = "+1 Move for the rest of the game";
        static readonly ItemType itemType = ItemType.ELIXIR_OF_SPEED;
        static readonly EffectType effectType = EffectType.SELF_ONLY;
        static readonly int price = 50;

        public ElixirOfSpeed() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure)
        {
            targetFigure.EffectiveMove += 1;
        }
    }
}
