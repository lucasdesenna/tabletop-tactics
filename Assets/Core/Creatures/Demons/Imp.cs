using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class Imp : Creature
    {
        static readonly string name = "Imp";
        static readonly string description = "Imps are generally the smallest and least powerful of demons. They tend to be smaller than a human, but the infinity of forms across the planes of existence means that they can appear as practically anything – a mass of flesh defined solely by a giant mouth, a spindly insect creature with vestigial wings, a crooked imitation of a man, a humanoid rat…";
        static readonly CreatureCategory creatureCategory = CreatureCategory.DEMON;
        static readonly CreatureType creatureType = CreatureType.IMP;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 1;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 4;
        static readonly int health = 6;

        public Imp() : base(
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
