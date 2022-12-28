using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Entities
{
    public sealed class Apprentice : IWizard
    {
        private readonly string _name;
        public string Name => _name;

        private readonly Gender _gender;
        public Gender Gender => _gender;

        private readonly int _armour;
        public int Armour => _armour;

        public int EffectiveArmour { get; set; }

        private readonly int _fight;
        public int Fight => _fight;

        public int EffectiveFight { get; set; }

        private readonly int _maxHealth;
        public int MaxHealth => _maxHealth;

        public int Health { get; set; }

        private readonly int _move;
        public int Move => _move;

        public int EffectiveMove { get; set; }

        private readonly int _shoot;
        public int Shoot => _shoot;

        public int EffectiveShoot { get; set; }

        private readonly int _will;
        public int Will => _will;

        public int EffectiveWill { get; set; }

        private readonly int _itemCapacity;
        public int? ItemCapacity => _itemCapacity;

        private readonly List<IItem> _items = new();
        public List<IItem> Items { get => _items; }

        public readonly WizardType WizardType;

        private int _level = 0;
        public int Level { get => _level; private set => _level = value; }

        private int _experience = 0;
        public int Experience { get => _experience; private set => _experience = value; }

        public Apprentice(string name,
                          Gender gender,
                          WizardType wizardType)
        {
            _name = name;
            _gender = gender;
            WizardType = wizardType;
            _move = 6;
            _fight = 0;
            _shoot = -2;
            _armour = 10;
            _will = 2;
            _health = 10;
            _itemCapacity = 4;
        }

        public Grimoire Grimoire { get; }

        public WizardType Type { get; }

        public void GainExperience(int experience)
        {
            _experience += experience;
            _level += _experience / 100;
            _experience %= 100;
        }
    }
}
