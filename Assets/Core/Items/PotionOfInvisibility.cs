using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class PotionOfInvisibility : Potion
    {
        static readonly string name = "Potion of Invisibility";
        static readonly string description = "As an Invisibility spell, no casting roll needed";
        static readonly int price = 100;

        public PotionOfInvisibility() : base(
            PotionOfInvisibility.name,
            PotionOfInvisibility.description,
            ItemType.POTION_OF_INVISIBILITY,
            PotionOfInvisibility.price)
        { }
    }
}
