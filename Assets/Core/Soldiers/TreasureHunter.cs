using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class TreasureHunter : Soldier
    {
        public TreasureHunter(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.TREASURE_HUNTER,
            7,
            4,
            0,
            11,
            2,
            12,
            80)
        { }
    }
}
