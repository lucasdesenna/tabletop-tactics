using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface IFigure
    {
        public string Name { get; }
        public Gender Gender {get; }
        public int Armour { get; }
        public int EffectiveArmour { get; set; }
        public int Fight { get; }
        public int EffectiveFight { get; set; }
        public int MaxHealth { get; }
        public int Health { get; set; }
        public int Move { get; }
        public int EffectiveMove { get; set; }
        public int Shoot { get; }
        public int EffectiveShoot { get; set; }
        public int Will { get; }
        public int EffectiveWill { get; set; }

        public void ResetAttributes()
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
