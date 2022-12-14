using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Thug : Soldier
    {
        public Thug(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.THUG,
            6,
            2,
            0,
            10,
            -1,
            10,
            20)
        { }
    }
}
