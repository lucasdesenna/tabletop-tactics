using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Templar : Soldier
    {
        public Templar(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.TEMPLAR,
            5,
            4,
            0,
            12,
            1,
            12,
            100)
        { }
    }
}
