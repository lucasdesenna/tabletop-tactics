using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Crossbowman : Soldier
    {
        public Crossbowman(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.CROSSBOWMAN,
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
