using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public class Trinket : Item
    {
        public Trinket(string name, string description, ItemType itemType, int value)
             : base(name, description, ItemClass.TRINKET, itemType, value) { }
    }
}