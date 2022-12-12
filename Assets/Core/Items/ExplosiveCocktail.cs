using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class ExplosiveCocktail : Potion
    {
        static readonly string name = "Explosive Cocktail";
        static readonly string description = "As a Grenade spell, no casting roll needed.";
        static readonly int value = 50;

        public ExplosiveCocktail() : base(
            ExplosiveCocktail.name,
            ExplosiveCocktail.description,
            ItemType.EXPLOSIVE_COCKTAIL,
            ExplosiveCocktail.value)
        { }
    }
}
