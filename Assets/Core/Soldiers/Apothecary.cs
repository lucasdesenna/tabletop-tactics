using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class Apothecary : Soldier
    {
        public Apothecary(string name, Gender gender) : base(
             name,
             gender,
            SoldierType.APOTHECARY,
            6,
            0,
            0,
            10,
            0,
            12,
            100)
        { }
    }
}
