using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Warband.Soldiers
{
    public sealed class Crossbowman : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.CROSSBOWMAN;
        static readonly int move = 6;
        static readonly int fight = 2;
        static readonly int shoot = 2;
        static readonly int armour = 11;
        static readonly int will = 0;
        static readonly int health = 10;
        static readonly int price = 50;

        public Crossbowman(string name, Gender gender) : base(
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
