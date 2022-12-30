using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Creatures.Animals
{
    internal class Werewolf : Creature
    {
        static readonly string name = "Werewolf";
        static readonly string description = "The werewolves that inhabit the ruins of the city are not true lycanthropes. They are not shape shifters, but some kind of wolf–human hybrid. Although they live in small packs, they hunt alone and are thus normally encountered individually. The heads of werewolves are highly prized trophies – any figure that kills a werewolf may spend an extra turn cutting off its head, which may be sold for 20gc after the game.";
        static readonly CreatureCategory creatureCategory = CreatureCategory.MISC;
        static readonly CreatureType creatureType = CreatureType.WEREWOLF;
        static readonly HashSet<Tag> tags = new() { Tag.AGILE, Tag.HAS_BOUNTY };
        static readonly int move = 7;
        static readonly int fight = 4;
        static readonly int shoot = 0;
        static readonly int armour = 11;
        static readonly int will = 5;
        static readonly int health = 12;

        public Werewolf() : base(
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
