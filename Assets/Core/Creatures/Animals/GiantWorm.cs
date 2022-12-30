using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class GiantWorm : Creature
    {
        static readonly string name = "Giant Worm";
        static readonly string description = "The giant worms that move beneath the city are, like so many of the dangers of Frostgrave, a legacy of the old days. They were originally bred to clean the city’s sewer system, devouring all of the waste. It is unknown if they were frozen and thawed or if they have been active and breeding in the last thousand years but, either way, it is clear that there is no longer enough food for them in the sewer system, and they often come out to hunt.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.GIANT_WORM;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 7;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 5;
        static readonly int health = 20;

        public GiantWorm() : base(
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
