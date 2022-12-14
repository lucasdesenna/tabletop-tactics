using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Ranger : Soldier
    {
        public Ranger(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.RANGER,
            7,
            2,
            2,
            11,
            2,
            12,
            100)
        { }
    }
}
