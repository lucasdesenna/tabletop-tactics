using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Barbarian : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.BARBARIAN;
        static readonly int move = 6;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 3;
        static readonly int health = 14;
        static readonly int price = 100;

        public Barbarian(string name, Gender gender) : base(
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
