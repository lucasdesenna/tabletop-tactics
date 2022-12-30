using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Constructs
{
    internal class MediumConstruct : Creature
    {
        static readonly string name = "Medium Construct";
        static readonly string description = "These are around human size and come in all types, from humanoid designs to machines designed for a specific purpose, such as chopping wood, washing clothes or serving as a mount.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.CONSTRUCT;
        static readonly CreatureType creatureType = CreatureType.MEDIUM_CONSTRUCT;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 5;
        static readonly int fight = 1;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 0;
        static readonly int health = 12;

        public MediumConstruct() : base(
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
