using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class WildDog : Creature
    {
        static readonly string name = "Wild Dog";
        static readonly string description = "Several large packs of wild dogs now roam the ruins of Frostgrave. Generally, these animals are scrawny, chronically malnourished, and often diseased members of the species. Unfortunately, this has also made them aggressive.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.WILD_DOG;
        static readonly HashSet<Tag> tags = new() { Tag.PACK_HUNTER };
        static readonly int move = 8;
        static readonly int fight = 0;
        static readonly int shoot = 0;
        static readonly int armour = 8;
        static readonly int will = 0;
        static readonly int health = 4;

        public WildDog() : base(
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
