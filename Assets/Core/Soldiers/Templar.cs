using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Templar : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.TEMPLAR;
        static readonly int move = 5;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 1;
        static readonly int health = 12;
        static readonly int price = 100;

        public Templar(string name, Gender gender) : base(
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
