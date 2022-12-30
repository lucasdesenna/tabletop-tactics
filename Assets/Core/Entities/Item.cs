using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System;
using UnityEngine;

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

        private readonly int _price;
        public int Price => _price;

        private readonly EffectType _effectType;
        public EffectType EffectType => _effectType;

        public abstract void ItemEffect();
        public abstract void ItemEffect(IFigure targetFigure);
        public abstract void ItemEffect(IFigure targetFigure, Vector3 targetPoint);

        static private void VerifyClassAndTypeCombination(ItemClass itemClass, ItemType itemType)
        {
            if ((int)itemClass * 100 < (int)itemType &&
                (int)itemType < (int)itemClass * 100 + 99)
            {
                throw new Exception(String.Format("Invalid ItemClass and ItemType combination: {0} {1}",
                    itemClass, itemType));
            }
        }

        public Item(string name, string description, ItemClass itemClass, ItemType itemType, EffectType effectType, int price)
        {
            Item.VerifyClassAndTypeCombination(itemClass, itemType);

            _name = name;
            _description = description;
            _itemClass = itemClass;
            _itemType = itemType;
            _effectType = effectType;
            _price = price;
        }
    }
}