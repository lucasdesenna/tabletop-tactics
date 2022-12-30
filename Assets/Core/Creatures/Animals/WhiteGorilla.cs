using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class WhiteGorilla : Creature
    {
        static readonly string name = "White Gorilla";
        static readonly string description = "Although rarely seen, at least one colony of white gorillas make their home in the city. While the females and young generally stay inside a nest, deep within the ruins, the males go out hunting and are not above eating human flesh.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.WHITE_GORILLA;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 6;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 12;
        static readonly int will = 8;
        static readonly int health = 14;

        public WhiteGorilla() : base(
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
