using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Infantryman : Soldier
    {
        public Infantryman(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.INFANTRYMAN,
            6,
            3,
            0,
            11,
            0,
            10,
            50)
        { }
    }
}
