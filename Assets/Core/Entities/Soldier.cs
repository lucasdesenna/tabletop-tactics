using System.Collections.Generic;

public sealed class Soldier : Figure
{
    public Soldier(FigureProfile profile,
                   SoldierType soldierType) : base(profile,
                                                   Soldier.AttributesBySolderType[soldierType],
                                                   new Inventory(1))
    {
        Type = soldierType;
    }

    static public Dictionary<SoldierType, FigureAttributes> AttributesBySolderType = new()
    {
        { SoldierType.APOTHECARY,      new FigureAttributes(6, 0, 0, 10,  0, 12) },
        { SoldierType.ARCHER,          new FigureAttributes(6, 2, 2, 11,  0, 10) },
        { SoldierType.BARBARIAN,       new FigureAttributes(6, 4, 0, 10,  3, 14) },
        { SoldierType.CROSSBOWMAN,     new FigureAttributes(6, 2, 2, 11,  0, 10) },
        { SoldierType.INFANTRYMAN,     new FigureAttributes(6, 3, 0, 11,  0, 10) },
        { SoldierType.KNIGHT,          new FigureAttributes(5, 4, 2, 13,  1, 12) },
        { SoldierType.MAN_AT_ARMS,     new FigureAttributes(6, 3, 0, 12,  1, 12) },
        { SoldierType.MARKSMAN,        new FigureAttributes(5, 2, 3, 12,  1, 12) },
        { SoldierType.RANGER,          new FigureAttributes(7, 2, 2, 11,  2, 12) },
        { SoldierType.TEMPLAR,         new FigureAttributes(5, 4, 0, 12,  1, 12) },
        { SoldierType.THIEF,           new FigureAttributes(7, 1, 0, 10,  0, 10) },
        { SoldierType.THUG,            new FigureAttributes(6, 2, 0, 10, -1, 10) },
        { SoldierType.TRACKER,         new FigureAttributes(7, 2, 0, 11,  1, 12) },
        { SoldierType.TREASURE_HUNTER, new FigureAttributes(7, 4, 0, 11,  2, 12) },
        { SoldierType.WAR_HOUND,       new FigureAttributes(8, 1, 0, 10,  2,  8) }
    };

    public SoldierType Type { get; }
}
