using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public abstract class Potion : Item
    {
        public Potion(string name, string description, ItemType itemType, int value) 
            : base(name, description, ItemClass.POTION, itemType, value) {}
    }
}