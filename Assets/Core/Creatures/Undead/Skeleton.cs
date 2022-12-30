using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Undead
{
    internal class Skeleton : Creature
    {
        static readonly string name = "Skeleton";
        static readonly string description = "Skeletons are the animated bones of some long-dead creature, held together and animated by the power of magic. Most skeletons in Frostgrave were originally humans, but skeletons of dogs or other animals are not uncommon";
        static readonly CreatureCategory creatureCategory = CreatureCategory.UNDEAD;
        static readonly CreatureType creatureType = CreatureType.SKELETON;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 1;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 0;
        static readonly int health = 1;

        public Skeleton() : base(
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
