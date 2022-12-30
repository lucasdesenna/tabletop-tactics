using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class SnowTroll : Creature
    {
        static readonly string name = "Snow Troll";
        static readonly string description = "Large, dumb and dangerous, the shaggy snow trolls encountered in the city are not to be taken lightly. Trolls consider anything that is alive and smaller than themselves to be food and will not hesitate to attack anyone they meet. Thankfully, trolls are slow and can usually be avoided or outpaced.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.MISC;
        static readonly CreatureType creatureType = CreatureType.SNOW_TROLL;
        static readonly HashSet<Tag> tags = new() { Tag.HUGE_WEAPON, Tag.LARGE };
        static readonly int move = 4;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 14;
        static readonly int will = 2;
        static readonly int health = 16;

        public SnowTroll() : base(
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
