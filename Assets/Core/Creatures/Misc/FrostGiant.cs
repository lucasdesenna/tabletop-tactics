using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class FrostGiant : Creature
    {
        static readonly string name = "Frost Giant";
        static readonly string description = "Ever since the great storm that destroyed the city, frost giants have occasionally wandered down from the northern mountains. Possessed of rudimentary intelligence, they can occasionally be reasoned with but generally they see humans (and most other animals) as little more than food.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.MISC;
        static readonly CreatureType creatureType = CreatureType.FROST_GIANT;
        static readonly HashSet<Tag> tags = new() { Tag.HUGE_WEAPON, Tag.LARGE };
        static readonly int move = 6;
        static readonly int fight = 5;
        static readonly int shoot = 0;
        static readonly int armour = 15;
        static readonly int will = 4;
        static readonly int health = 25;

        public FrostGiant() : base(
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
