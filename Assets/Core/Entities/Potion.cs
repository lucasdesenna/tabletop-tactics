using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public abstract class Potion : Item
    {
        public Potion(string name, string description, ItemType itemType, EffectType effectType, int price) 
            : base(name, description, ItemClass.POTION, itemType, effectType, price) {}
    }
}