using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;
using UnityEngine;

namespace Assets.Core.Items.Potions
{
    internal class PotionOfTeleportation : Potion
    {
        static readonly string name = "Potion of Teleportation";
        static readonly string description = "As a Teleport spell, no casting roll needed";
        static readonly ItemType itemType = ItemType.POTION_OF_TELEPORTATION;
        static readonly EffectType effectType = EffectType.TELEPORTATION;
        static readonly int price = 100;

        public PotionOfTeleportation() : base(
            name,
            description,
            itemType,
            effectType,
            price)
        { }

        public override void ItemEffect(IFigure targetFigure, Vector3 targetPoint)
        {
            
        }
    }
}
