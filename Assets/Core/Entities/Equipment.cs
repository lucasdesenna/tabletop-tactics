using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public class Equipment : Item
    {
        public Equipment(string name, string description, ItemType itemType, int value)
            : base(name, description, ItemClass.EQUIPMENT, itemType, value) { }
    }
}