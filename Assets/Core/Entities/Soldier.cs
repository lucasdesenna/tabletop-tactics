using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System.Collections.Generic;

namespace Assets.Core.Entities
{
    public abstract class Soldier : ISoldier
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
        public List<IItem> Items => _items;

        private readonly SoldierType _soldierType;
        public SoldierType SoldierType => _soldierType;

        private readonly int _price;
        public int Price => _price;

        public Soldier(string name,
                      Gender gender,
                      SoldierType soldierType,
                      int move,
                      int fight,
                      int shoot,
                      int armour,
                      int will,
                      int health,
                      int price)
        {
            _name = name;
            _gender = gender;
            _soldierType = soldierType;
            _move = move;
            _fight = fight;
            _shoot = shoot;
            _armour = armour;
            _will = will;
            _health = health;
            _price = price;
            _itemCapacity = 1;
        }
    }
}
