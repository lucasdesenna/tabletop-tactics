using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System.Collections.Generic;

namespace Assets.Core.Entities
{
    public interface IWizard : IFigure, IWithInventory
    {
        int Experience { get; }
        int Level { get; }
        bool CanPromoteApprentice => Level >= 10;
        void GainExperience(int experience);
    }

    public sealed class Wizard : IWizard
    {
        private readonly string _name;
        public string Name => _name;

        private readonly Gender _gender;
        public Gender Gender => _gender;

        private readonly int _armour;
        public int Armour => _armour;

        private readonly int _fight;
        public int Fight => _fight;

        private readonly int _health;
        public int Health => _health;

        private readonly int _move;
        public int Move => _move;

        private readonly int _shoot;
        public int Shoot => _shoot;

        private readonly int _will;
        public int Will => _will;

        private readonly int _itemCapacity;
        public int? ItemCapacity => _itemCapacity;

        private readonly List<IItem> _items = new();
        public List<IItem> Items { get => _items; }

        private int _level = 0;
        public int Level { get => _level; private set => _level = value; }

        private int _experience = 0;
        public int Experience { get => _experience; private set => _experience = value; }

        public readonly WizardType WizardType;

        public Wizard(string name,
                      Gender gender,
                      WizardType wizardType)
        {
            _name = name;
            _gender = gender;
            WizardType = wizardType;
            _move = 6;
            _fight = 2;
            _shoot = 0;
            _armour = 10;
            _will = 4;
            _health = 14;
            _itemCapacity = 5;
        }

        public void GainExperience(int experience)
        {
            _experience += experience;
            _level += _experience / 100;
            _experience %= 100;
        }
    }
}
