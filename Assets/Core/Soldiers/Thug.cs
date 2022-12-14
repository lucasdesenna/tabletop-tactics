using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Thug : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.THUG;
        static readonly int move = 6;
        static readonly int fight = 2;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = -1;
        static readonly int health = 10;
        static readonly int price = 20;

        public Thug(string name, Gender gender) : base(
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
