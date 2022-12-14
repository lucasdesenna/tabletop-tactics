using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Soldiers
{
    public sealed class ManAtArms : Soldier
    {
        public ManAtArms(string name, Gender gender) : base(
            name,
            gender,
            SoldierType.MAN_AT_ARMS,
            6,
            3,
            0,
            12,
            1,
            12,
            80)
        { }
    }
}
