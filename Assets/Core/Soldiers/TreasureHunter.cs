using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class TreasureHunter : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.TREASURE_HUNTER;
        static readonly int move = 7;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 11;
        static readonly int will = 2;
        static readonly int health = 12;
        static readonly int price = 80;

        public TreasureHunter(string name, Gender gender) : base(
            name,
            gender,
            soldierType,
            move,
            fight,
            shoot,
            armour,
            will,
            health,
            price)
        { }
    }
}
