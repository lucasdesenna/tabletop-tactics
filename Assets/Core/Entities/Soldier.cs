using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System.Collections.Generic;

namespace Assets.Core.Entities
{
    public interface ISoldier : IFigure, IWithInventory
    {
        SoldierType SoldierType { get; }
    }

    public sealed class Soldier : ISoldier
    {
        private readonly string _name;
        public string Name => _name;

        private readonly Gender _gender;
        public Gender Gender => _gender;

        private readonly int _armour;
        public int Armour => _armour;

        private readonly int _fight;
        public int Fight => _fight;

        private readonly int _health;
        public int Health => _health;

        private readonly int _move;
        public int Move => _move;

        private readonly int _shoot;
        public int Shoot => _shoot;

        private readonly int _will;
        public int Will => _will;

        private readonly int _itemCapacity;
        public int? ItemCapacity => _itemCapacity;

        private readonly List<IItem> _items = new();
        public List<IItem> Items => _items;

        private readonly SoldierType _soldierType;
        public SoldierType SoldierType => _soldierType;

        public Soldier(string name,
                       Gender gender,
                       SoldierType soldierType)
        {
            IDictionary<FigureAttribute, int> figureAttributes = Soldier.figureAttributesBySolderType[soldierType];

            _name = name;
            _gender = gender;
            _soldierType = soldierType;
            _move = figureAttributes[FigureAttribute.MOVE];
            _fight = figureAttributes[FigureAttribute.FIGHT];
            _shoot = figureAttributes[FigureAttribute.SHOOT];
            _armour = figureAttributes[FigureAttribute.ARMOUR];
            _will = figureAttributes[FigureAttribute.WILL];
            _health = figureAttributes[FigureAttribute.HEALTH];
            _itemCapacity = 1;
        }

        public static Dictionary<SoldierType, Dictionary<FigureAttribute, int>> figureAttributesBySolderType = new()
        {
            { SoldierType.APOTHECARY, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  0  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 10 },
                    { FigureAttribute.WILL,   0  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.ARCHER, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  2  },
                    { FigureAttribute.SHOOT,  2  },
                    { FigureAttribute.ARMOUR, 11 },
                    { FigureAttribute.WILL,   0  },
                    { FigureAttribute.HEALTH, 10 }
                }
            },
            { SoldierType.BARBARIAN, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  4  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 10 },
                    { FigureAttribute.WILL,   3  },
                    { FigureAttribute.HEALTH, 14 }
                }
            },
            { SoldierType.CROSSBOWMAN, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  2  },
                    { FigureAttribute.SHOOT,  2  },
                    { FigureAttribute.ARMOUR, 11 },
                    { FigureAttribute.WILL,   0  },
                    { FigureAttribute.HEALTH, 10 }
                }
            },
            { SoldierType.INFANTRYMAN, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  3  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 11 },
                    { FigureAttribute.WILL,   0  },
                    { FigureAttribute.HEALTH, 10 }
                }
            },
            { SoldierType.KNIGHT, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   5  },
                    { FigureAttribute.FIGHT,  4  },
                    { FigureAttribute.SHOOT,  2  },
                    { FigureAttribute.ARMOUR, 13 },
                    { FigureAttribute.WILL,   1  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.MAN_AT_ARMS, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  3  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 12 },
                    { FigureAttribute.WILL,   1  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.MARKSMAN, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   5  },
                    { FigureAttribute.FIGHT,  2  },
                    { FigureAttribute.SHOOT,  3  },
                    { FigureAttribute.ARMOUR, 12 },
                    { FigureAttribute.WILL,   1  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.RANGER, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   7  },
                    { FigureAttribute.FIGHT,  2  },
                    { FigureAttribute.SHOOT,  2  },
                    { FigureAttribute.ARMOUR, 11 },
                    { FigureAttribute.WILL,   2  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.TEMPLAR, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   5  },
                    { FigureAttribute.FIGHT,  4  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 12 },
                    { FigureAttribute.WILL,   1  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.THIEF, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   7  },
                    { FigureAttribute.FIGHT,  1  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 10 },
                    { FigureAttribute.WILL,   0  },
                    { FigureAttribute.HEALTH, 10 }
                }
            },
            { SoldierType.THUG, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   6  },
                    { FigureAttribute.FIGHT,  2  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 10 },
                    { FigureAttribute.WILL,   -1 },
                    { FigureAttribute.HEALTH, 10 }
                }
            },
            { SoldierType.TRACKER, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   7  },
                    { FigureAttribute.FIGHT,  2  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 11 },
                    { FigureAttribute.WILL,   1  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.TREASURE_HUNTER, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   7  },
                    { FigureAttribute.FIGHT,  4  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 11 },
                    { FigureAttribute.WILL,   2  },
                    { FigureAttribute.HEALTH, 12 }
                }
            },
            { SoldierType.WAR_HOUND, new Dictionary<FigureAttribute, int>()
                {
                    { FigureAttribute.MOVE,   8  },
                    { FigureAttribute.FIGHT,  1  },
                    { FigureAttribute.SHOOT,  0  },
                    { FigureAttribute.ARMOUR, 10 },
                    { FigureAttribute.WILL,   2  },
                    { FigureAttribute.HEALTH, 8 }
                }
            },
        };
    }
}
