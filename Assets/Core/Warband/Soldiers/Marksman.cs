using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Warband.Soldiers
{
    public sealed class Marksman : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.MARKSMAN;
        static readonly int move = 5;
        static readonly int fight = 2;
        static readonly int shoot = 3;
        static readonly int armour = 12;
        static readonly int will = 1;
        static readonly int health = 12;
        static readonly int price = 100;

        public Marksman(string name, Gender gender) : base(
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
