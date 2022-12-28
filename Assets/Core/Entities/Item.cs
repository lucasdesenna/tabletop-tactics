using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System;

namespace Assets.Core.Entities
{
    public abstract class Item : IItem
    {
        private readonly string _name;
        public string Name => _name;

        private readonly string _description;
        public string Description => _description;

        private readonly ItemClass _itemClass;
        public ItemClass ItemClass => _itemClass;

        private readonly ItemType _itemType;
        public ItemType ItemType => _itemType;

        private readonly int _value;
        public int Price => _value;

        public abstract void ItemEffect(IFigure ownerFigure, IFigure targetFigure, IGameboard gameboard);

        static private void VerifyClassAndTypeCombination(ItemClass itemClass, ItemType itemType)
        {
            if ((int)itemClass * 100 < (int)itemType &&
                (int)itemType < (int)itemClass * 100 + 99)
            {
                throw new Exception(String.Format("Invalid ItemClass and ItemType combination: {0} {1}",
                    itemClass, itemType));
            }
        }

        public Item(string name, string description, ItemClass itemClass, ItemType itemType, int value)
        {
            Item.VerifyClassAndTypeCombination(itemClass, itemType);

            _name = name;
            _description = description;
            _itemClass = itemClass;
            _itemType = itemType;
            _value = value;
        }
    }
}