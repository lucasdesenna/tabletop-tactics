using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class SnowLeopard : Creature
    {
        static readonly string name = "Snow Leopard";
        static readonly string description = "The largest and most vicious of the big cats around Frostgrave, the snow leopard is a dangerous hunter. They have no fear of humans and will attack if they are hungry or feel threatened.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.SNOW_LEOPARD;
        static readonly HashSet<Tag> tags = new();
        static readonly int move = 8;
        static readonly int fight = 2;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 2;
        static readonly int health = 10;

        public SnowLeopard() : base(
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
