using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public class Potion : Item
    {
        public readonly PotionType PotionType;

        public Potion(string name, string description, PotionType potionType) 
            : base(name, description, ItemType.POTION)
        {
            PotionType = potionType;
        }
    }
}