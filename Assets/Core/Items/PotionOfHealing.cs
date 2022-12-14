using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class PotionOfHealing : Potion
    {
        static readonly string name = "Potion of Healing";
        static readonly string description = "Restores up to 5 lost Health";
        static readonly int price = 50;

        public PotionOfHealing() : base(
            PotionOfHealing.name,
            PotionOfHealing.description,
            ItemType.POTION_OF_HEALING,
            PotionOfHealing.price)
        { }
    }
}
