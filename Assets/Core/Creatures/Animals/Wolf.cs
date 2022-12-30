using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class Wolf : Creature
    {
        static readonly string name = "Wolf";
        static readonly string description = "Wolves tend to shy away from humans, but one or two will occasionally wander down into the city in search of prey.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.WOLF;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 8;
        static readonly int fight = 1;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 0;
        static readonly int health = 6;

        public Wolf() : base(
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
