using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class ExplosiveCocktail : Potion
    {
        static readonly string name = "Explosive Cocktail";
        static readonly string description = "As a Grenade spell, no casting roll needed.";
        static readonly ItemType itemType = ItemType.EXPLOSIVE_COCKTAIL;
        static readonly int price = 50;

        public ExplosiveCocktail() : base(
            name,
            description,
            itemType,
            price)
        { }
    }
}
