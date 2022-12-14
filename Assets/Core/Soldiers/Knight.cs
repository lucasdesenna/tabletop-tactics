using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Knight : Soldier
    {
        public Knight(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.KNIGHT,
            5,
            4,
            0,
            13,
            1,
            12,
            100)
        { }
    }
}
