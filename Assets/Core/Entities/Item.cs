using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public class Item
    {
        public readonly string Name;

        public readonly string Description;

        public readonly ItemType ItemType;

        public Item(string name, string description, ItemType itemType)
        {
            Name = name;
            Description = description;
            ItemType = itemType;
        }
    }
}