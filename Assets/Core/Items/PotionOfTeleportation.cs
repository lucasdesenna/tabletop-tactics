using Assets.Core.Entities;
using Assets.Core.Enums;

namespace Assets.Core.Items
{
    internal class PotionOfTeleportation : Potion
    {
        static readonly string name = "Potion of Teleportation";
        static readonly string description = "As a Teleport spell, no casting roll needed";
        static readonly int value = 100;

        public PotionOfTeleportation() : base(
            PotionOfTeleportation.name,
            PotionOfTeleportation.description,
            ItemType.POTION_OF_TELEPORTATION,
            PotionOfTeleportation.value)
        { }
    }
}
