using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class MinorDemon : Creature
    {
        static readonly string name = "Minor Demon";
        static readonly string description = "While the human-sized minor demons, like imps, come in an infinite number of forms, some distinct ‘species’ can be identified, such as the ‘gargoyles’ – hunched, grey-skinned creatures that find homes amongst the ruined architecture of Frostgrave.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.DEMON;
        static readonly CreatureType creatureType = CreatureType.MINOR_DEMON;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 3;
        static readonly int shoot = 0;
        static readonly int armour = 11;
        static readonly int will = 4;
        static readonly int health = 12;

        public MinorDemon() : base(
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
