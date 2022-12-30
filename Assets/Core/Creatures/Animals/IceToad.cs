using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class IceToad : Creature
    {
        static readonly string name = "Ice Toad";
        static readonly string description = "These large and ponderous amphibians have devastatingly powerful jaws, but are otherwise weak. It is generally just best to avoid them.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.ICE_TOAD;
        static readonly HashSet<Tag> tags = new() { Tag.POWERFUL_JAWS };
        static readonly int move = 3;
        static readonly int fight = 2;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 0;
        static readonly int health = 5;

        public IceToad() : base(
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
