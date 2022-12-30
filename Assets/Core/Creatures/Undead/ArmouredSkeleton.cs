using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Undead
{
    internal class ArmouredSkeleton : Creature
    {
        static readonly string name = "Armoured Skeleton";
        static readonly string description = "Armoured skeletons are skeletons that were animated specifically to use as soldiers. Due to their more demanding role, they are harder to create, but are generally tougher, more aggressive, and better-equipped.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.UNDEAD;
        static readonly CreatureType creatureType = CreatureType.ARMOURED_SKELETON;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 2;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 0;
        static readonly int health = 1;

        public ArmouredSkeleton() : base(
            name,
            description,
            creatureCategory,
            creatureType,
            tags,
            move,
            fight,
            shoot,
            armour,
            will,
            health)
        { }
    }
}
