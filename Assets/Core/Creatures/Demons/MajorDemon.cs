using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class MajorDemon : Creature
    {
        static readonly string name = "Major Demon";
        static readonly string description = "Major demons are powerful individual entities. There is no limit to the size or shape they can take,\r\nand some are capable of changing forms at will. They appear as flawlessly beautiful humans,\r\ngrotesque hybrids of multiple animals, giant amorphous blobs, floating spheres of light, or anything else that can be imagined. The stats given below are just a guideline, as major demons will often have their own magic powers or abilities, or access to a number of spells.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.DEMON;
        static readonly CreatureType creatureType = CreatureType.MAJOR_DEMON;
        static readonly HashSet<Tag> tags = new() { Tag.LARGE };
        static readonly int move = 6;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 6;
        static readonly int health = 15;

        public MajorDemon() : base(
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
