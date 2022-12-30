using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Constructs
{
    internal class LargeConstruct : Creature
    {
        static readonly string name = "Large Construct";
        static readonly string description = "These are larger than a human and, while often still humanoid in shape, can also be found as selfpropelled ‘living’ wagons or carriages or with designs inspired by larger animals such as bears.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.CONSTRUCT;
        static readonly CreatureType creatureType = CreatureType.LARGE_CONSTRUCT;
        static readonly HashSet<Tag> tags = new() { Tag.LARGE };
        static readonly int move = 4;
        static readonly int fight = 3;
        static readonly int shoot = 0;
        static readonly int armour = 13;
        static readonly int will = 0;
        static readonly int health = 14;

        public LargeConstruct() : base(
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
