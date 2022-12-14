using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class WarHound : Soldier
    {
        public WarHound(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.WAR_HOUND,
            8,
            1,
            0,
            10,
            2,
            8,
            10)
        { }
    }
}
