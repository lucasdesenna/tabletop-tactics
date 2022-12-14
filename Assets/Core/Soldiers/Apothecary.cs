using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Apothecary : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.APOTHECARY;
        static readonly int move = 6;
        static readonly int fight = 0;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 0;
        static readonly int health = 12;
        static readonly int price = 100;

        public Apothecary(string name, Gender gender) : base(
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
