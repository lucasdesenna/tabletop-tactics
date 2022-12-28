using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public abstract class Equipment : Item
    {
        public Equipment(string name, string description, ItemType itemType, int value)
            : base(name, description, ItemClass.EQUIPMENT, itemType, value) { }
    }
}