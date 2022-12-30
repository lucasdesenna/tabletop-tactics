using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class IceSpider : Creature
    {
        static readonly string name = "Ice Spider";
        static readonly string description = "These hairy arachnids vary in size, but are generally about the size of a wolf. These spiders do not spin webs – they are active hunters. Generally, they feed on rodents and other small mammals, but are not averse to trying their luck with larger prey. Although not particularly strong, ice spiders are quick and their bite releases a dangerous venom.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.ANIMAL;
        static readonly CreatureType creatureType = CreatureType.ICE_SPIDER;
        static readonly HashSet<Tag> tags = new() { Tag.VENOM };
        static readonly int move = 6;
        static readonly int fight = 0;
        static readonly int shoot = 0;
        static readonly int armour = 8;
        static readonly int will = 0;
        static readonly int health = 4;

        public IceSpider() : base(
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
