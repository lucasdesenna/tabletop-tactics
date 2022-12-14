using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Thief : Soldier
    {
        public Thief(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.THIEF,
            7,
            1,
            0,
            10,
            0,
            10,
            20)
        { }
    }
}
