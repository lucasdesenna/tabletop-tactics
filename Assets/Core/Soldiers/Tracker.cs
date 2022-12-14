using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Tracker : Soldier
    {
        public Tracker(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.TRACKER,
            7,
            2,
            2,
            11,
            1,
            12,
            80)
        { }
    }
}
