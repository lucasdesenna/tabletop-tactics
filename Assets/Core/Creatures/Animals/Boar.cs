using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class Boar : Creature
    {
        static readonly string name = "Boar";
        static readonly string description = "Bad-tempered and aggressive, wild boars are also very tasty and thus much sought-after in the Frozen City.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.BOAR;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 2;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 2;
        static readonly int health = 8;

        public Boar() : base(
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
