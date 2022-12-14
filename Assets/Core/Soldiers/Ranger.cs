using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Ranger : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.RANGER;
        static readonly int move = 7;
        static readonly int fight = 2;
        static readonly int shoot = 2;
        static readonly int armour = 11;
        static readonly int will = 2;
        static readonly int health = 12;
        static readonly int price = 100;

        public Ranger(string name, Gender gender) : base(
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
