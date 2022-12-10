using Assets.Core.Enums;

namespace Assets.Core.Entities
{
    public class Equipment : Item
    {
        public readonly EquipmentType EquipmentType;

        public Equipment(string name, string description, EquipmentType equipmentType)
            : base(name, description, ItemType.EQUIPMENT)
        {
            EquipmentType = equipmentType;
        }
    }
}