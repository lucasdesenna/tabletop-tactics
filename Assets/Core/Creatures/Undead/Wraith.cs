using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Undead
{
    internal class Wraith : Creature
    {
        static readonly string name = "Wraith";
        static readonly string description = "‘Wraith’ is a catch-all term for the various forms of ethereal undead in the city, although ‘ghost’ and ‘wight’ are also used. It is not known how they are created, and no-one is sure if the ones currently haunting the city come from before or after its fall. What is known, though, is that a wraith is both extremely dangerous and hard to kill – their touch can drain a victim’s life force, and they are immune to non-magic weapons.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.UNDEAD;
        static readonly CreatureType creatureType = CreatureType.WRAITH;
        static readonly HashSet<Tag> tags = new() { Tag.IMMATERIAL, Tag.DRAINS_LIFE_FORCE, Tag.IMMUNE_TO_NON_MAGICAL_DAMAGE};
        static readonly int move = 6;
        static readonly int fight = 2;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 3;
        static readonly int health = 6;

        public Wraith() : base(
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
