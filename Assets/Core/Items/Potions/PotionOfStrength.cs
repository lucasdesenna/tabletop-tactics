using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;

namespace Assets.Core.Items.Potions
{
    internal class PotionOfStrength : Potion
    {
        static readonly string name = "Potion of Strength";
        static readonly string description = "+2 Fight for the rest of the game";
        static readonly ItemType itemType = ItemType.POTION_OF_STRENGTH;
        static readonly EffectType effectType = EffectType.SELF_ONLY;
        static readonly int price = 50;

        public PotionOfStrength() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure)
        {
            targetFigure.EffectiveFight += 2;
        }
    }
}
