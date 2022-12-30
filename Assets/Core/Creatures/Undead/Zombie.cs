using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Undead
{
    internal class Zombie : Creature
    {
        static readonly string name = "Zombie";
        static readonly string description = "Zombies probably outnumber all the other inhabitants of Frostgrave combined. Unlike skeletons, these undead were reanimated soon after death and still have most of their flesh. Before the cataclysm, zombies were chiefly used as household servants and messengers. Now, they have gone feral and hunger for living flesh.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.UNDEAD;
        static readonly CreatureType creatureType = CreatureType.ZOMBIE;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 4;
        static readonly int fight = 0;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 0;
        static readonly int health = 6;

        public Zombie() : base(
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
