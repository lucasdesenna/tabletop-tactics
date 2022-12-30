using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System;

namespace Assets.Core.Items.Potions
{
    internal class PotionOfHealing : Potion
    {
        static readonly string name = "Potion of Healing";
        static readonly string description = "Restores up to 5 lost Health";
        static readonly ItemType itemType = ItemType.POTION_OF_HEALING;
        static readonly EffectType effectType = EffectType.SELF_ONLY;
        static readonly int price = 50;

        public PotionOfHealing() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure)
        {
            targetFigure.Health = Math.Min(targetFigure.Health + 5, targetFigure.MaxHealth);
        }
    }
}
