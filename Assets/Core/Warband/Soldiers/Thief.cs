using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Warband.Soldiers
{
    public sealed class Thief : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.THIEF;
        static readonly int move = 7;
        static readonly int fight = 1;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 0;
        static readonly int health = 10;
        static readonly int price = 20;

        public Thief(string name, Gender gender) : base(
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
