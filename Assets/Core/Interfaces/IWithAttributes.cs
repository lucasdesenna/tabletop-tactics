using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface IWithAttributes
    {
        int Armour { get; }
        int EffectiveArmour { get; set; }
        int Fight { get; }
        int EffectiveFight { get; set; }
        int MaxHealth { get; }
        int Health { get; set; }
        int Move { get; }
        int EffectiveMove { get; set; }
        int Shoot { get; }
        int EffectiveShoot { get; set; }
        int Will { get; }
        int EffectiveWill { get; set; }

        void ResetAttributes()
        {
            EffectiveArmour = Armour;
            EffectiveFight = Fight;
            Health = MaxHealth;
            EffectiveMove = Move;
            EffectiveShoot = Shoot;
            EffectiveWill = Will;
        }
    }
}
