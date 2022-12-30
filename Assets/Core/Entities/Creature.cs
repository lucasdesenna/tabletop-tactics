using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System.Collections.Generic;

namespace Assets.Core.Entities
{
    public abstract class Creature : ICreature
    {
        public string Name { get; }
        public string Description { get; }
        public CreatureType CreatureType { get; }
        public CreatureCategory CreatureCategory { get; }
        public HashSet<Tag> Tags { get; }
        public int Armour { get; }
        public int EffectiveArmour { get; set; }
        public int Fight { get; }
        public int EffectiveFight { get; set; }
        public int MaxHealth { get; }
        public int Health { get; set; }
        public int Move { get; }
        public int EffectiveMove { get; set; }
        public int Shoot { get; }
        public int EffectiveShoot { get; set; }
        public int Will { get; }
        public int EffectiveWill { get; set; }
        public FigureState State { get; set; } = FigureState.NORMAL;

        public Creature(string name,
                      string description,
                      CreatureCategory creatureClass,
                      CreatureType creatureType,
                      HashSet<Tag> tags,
                      int move,
                      int fight,
                      int shoot,
                      int armour,
                      int will,
                      int maxHealth
            )
        {
            Name = name;
            Description = description;
            CreatureCategory = creatureClass;
            CreatureType = creatureType;
            Tags = tags;
            Move = move;
            Fight = fight;
            Shoot = shoot;
            Armour = armour;
            Will = will;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }
    }
}
