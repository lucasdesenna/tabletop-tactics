using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Archer : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.ARCHER;
        static readonly int move = 6;
        static readonly int fight = 2;
        static readonly int shoot = 2;
        static readonly int armour = 11;
        static readonly int will = 0;
        static readonly int health = 10;
        static readonly int price = 50;

        public Archer(string name, Gender gender) : base(
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
