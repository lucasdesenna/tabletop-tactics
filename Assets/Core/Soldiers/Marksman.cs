using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Marksman : Soldier
    {
        public Marksman(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.MARKSMAN,
            5,
            2,
            3,
            12,
            1,
            12,
            100)
        { }
    }
}
