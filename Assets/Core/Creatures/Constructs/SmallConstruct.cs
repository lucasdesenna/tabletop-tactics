using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Constructs
{
    internal class SmallConstruct : Creature
    {
        static readonly string name = "Small Construct";
        static readonly string description = "These are constructs that are smaller than most humans. They normally take the form of a small humanoid or animal, but could just as easily be an animated chair, child’s toy, or something even more unusual.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.CONSTRUCT;
        static readonly CreatureType creatureType = CreatureType.SMALL_CONSTRUCT;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 0;
        static readonly int shoot = 0;
        static readonly int armour = 11;
        static readonly int will = 0;
        static readonly int health = 10;

        public SmallConstruct() : base(
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
