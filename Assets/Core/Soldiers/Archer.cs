using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Archer : Soldier
    {
        public Archer(string name, Gender gender) : base(
             name,
             gender,
            SoldierType.ARCHER,
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
