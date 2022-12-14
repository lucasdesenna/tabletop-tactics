using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Barbarian : Soldier
    {
        public Barbarian(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.BARBARIAN,
            6,
            2,
            2,
            11,
            0,
            10,
            50)
        { }
    }
}
