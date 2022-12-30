using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class GiantRat : Creature
    {
        static readonly string name = "Giant Rat";
        static readonly string description = "Rats were one of the few species that did manage to survive the freezing of the city, hiding in some part of the ancient sewer system. There, they scavenged what food they could find, including potions and other magic items. Somehow, over the centuries, at least one strain evolved to produce rats the size of cats. Usually, giant rats are encountered in small packs which have been known to overwhelm weak or wounded adventurers.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.GIANT_RAT;
        static readonly HashSet<Tag> tags = new() { Tag.PACK_HUNTER };
        static readonly int move = 6;
        static readonly int fight = 0;
        static readonly int shoot = 0;
        static readonly int armour = 6;
        static readonly int will = 0;
        static readonly int health = 1;

        public GiantRat() : base(
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
