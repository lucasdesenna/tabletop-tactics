using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System;

namespace Assets.Core.Items.Potions
{
    internal class PotionOfInvisibility : Potion
    {
        static readonly string name = "Potion of Invisibility";
        static readonly string description = "The target figure becomes invisible and may not be attacked or targeted by spells (although they may still be affected by area effects, such as the blast radius of a Grenade spell). The effects of this potion last until the target attacks, casts a spell, or picks up an item of treasure. The potion can be consumed by a figure already carrying treasure, rendering both invisible.";
        static readonly ItemType itemType = ItemType.POTION_OF_INVISIBILITY;
        static readonly EffectType effectType = EffectType.SELF_ONLY;
        static readonly int price = 100;

        public PotionOfInvisibility() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure)
        {
            targetFigure.State = FigureState.INVISIBLE;
        }
    }
}
