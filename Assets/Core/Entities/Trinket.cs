using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public class Trinket : Item
    {
        public readonly TrinketType TrinketType;

        public Trinket(string name, string description, TrinketType trinketType) 
            : base(name, description, ItemType.TRINKET)
        {
            TrinketType = trinketType;
        }
    }
}