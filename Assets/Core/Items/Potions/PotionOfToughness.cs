using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;

namespace Assets.Core.Items.Potions
{
    internal class PotionOfToughness : Potion
    {
        static readonly string name = "Potion of Toughness";
        static readonly string description = "+1 Armour for the rest of the game";
        static readonly ItemType itemType = ItemType.POTION_OF_TOUGHNESS;
        static readonly EffectType effectType = EffectType.SELF_ONLY;
        static readonly int price = 50;

        public PotionOfToughness() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure)
        {
            targetFigure.EffectiveArmour += 1;
        }
    }
}
