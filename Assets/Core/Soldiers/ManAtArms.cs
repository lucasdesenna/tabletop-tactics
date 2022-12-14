using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class ManAtArms : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.MAN_AT_ARMS;
        static readonly int move = 6;
        static readonly int fight = 3;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 1;
        static readonly int health = 12;
        static readonly int price = 80;

        public ManAtArms(string name, Gender gender) : base(
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
