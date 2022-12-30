using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class Bear : Creature
    {
        static readonly string name = "Bear";
        static readonly string description = "Northern bears are mostly peaceful creatures but are easily spooked. If a bear is encountered in the city, it is safe to assume that it is already unhappy and desperate to leave.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.BEAR;
        static readonly HashSet<Tag> tags = new() { Tag.LARGE };
        static readonly int move = 6;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 0;
        static readonly int health = 14;

        public Bear() : base(
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
