using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class PotionOfStrength : Potion
    {
        static readonly string name = "Potion of Strength";
        static readonly string description = "+2 Fight for the rest of the game";
        static readonly int price = 50;

        public PotionOfStrength() : base(
            PotionOfStrength.name,
            PotionOfStrength.description,
            ItemType.POTION_OF_STRENGTH,
            PotionOfStrength.price)
        { }
    }
}
