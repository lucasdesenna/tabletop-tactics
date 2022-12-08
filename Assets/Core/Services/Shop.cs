using System.Collections.Generic;

public static class Shop
{
    static public Dictionary<SoldierType, int> CostBySolderType = new()
    {
        { SoldierType.APOTHECARY,      100 },
        { SoldierType.ARCHER,          50  },
        { SoldierType.BARBARIAN,       100 },
        { SoldierType.CROSSBOWMAN,     50  },
        { SoldierType.INFANTRYMAN,     50  },
        { SoldierType.KNIGHT,          100 },
        { SoldierType.MAN_AT_ARMS,     80  },
        { SoldierType.MARKSMAN,        100 },
        { SoldierType.RANGER,          100 },
        { SoldierType.TEMPLAR,         100 },
        { SoldierType.THIEF,           20  },
        { SoldierType.THUG,            20  },
        { SoldierType.TRACKER,         80  },
        { SoldierType.TREASURE_HUNTER, 80  },
        { SoldierType.WAR_HOUND,       10  }
    };

    static public int ApprenticeCost => 200;
}