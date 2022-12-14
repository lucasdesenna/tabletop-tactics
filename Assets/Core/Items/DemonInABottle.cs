using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    public class DemonInABottle : Potion
    {
        static readonly string name = "Demon in a Bottle";
        static readonly string description = "When smashed, summons and binds a minor demon to fight for the warband until the end of the game";
        static readonly int price = 200;

        public DemonInABottle() : base(
            DemonInABottle.name,
            DemonInABottle.description,
            ItemType.DEMON_IN_A_BOTTLE,
            DemonInABottle.price)
        { }
    }
}
