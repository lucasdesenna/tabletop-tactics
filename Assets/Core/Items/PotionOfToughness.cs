using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class PotionOfToughness : Potion
    {
        static readonly string name = "Potion of Toughness";
        static readonly string description = "+1 Armour for the rest of the game";
        static readonly ItemType itemType = ItemType.POTION_OF_TOUGHNESS;
        static readonly int price = 50;

        public PotionOfToughness() : base(
            name,
            description,
            itemType,
            price)
        { }
    }
}
