using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items.Potions
{
    internal class ExplosiveCocktail : Potion
    {
        static readonly string name = "Explosive Cocktail";
        static readonly string description = "The potion can be thrown at a target point within 12”, whereupon it explodes into hundreds of fragments. Every figure, including allies, within 1.5” of that point immediately suffers a +3 shooting attack";
        static readonly ItemType itemType = ItemType.EXPLOSIVE_COCKTAIL;
        static readonly EffectType effectType = EffectType.AREA_EFFECT;
        static readonly float effectRadius = 12;
        static readonly int price = 50;

        public ExplosiveCocktail() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }
    }
}
