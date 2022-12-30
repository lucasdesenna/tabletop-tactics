using Assets.Core.Entities;
using Assets.Core.Enums;
using System.Collections.Generic;

namespace Assets.Core.Warband.Soldiers
{
    public sealed class WarHound : Soldier
    {
        static readonly SoldierType soldierType = SoldierType.WAR_HOUND;
        static readonly int move = 8;
        static readonly int fight = 1;
        static readonly int shoot = 0;
        static readonly int armour = 10;
        static readonly int will = 2;
        static readonly int health = 8;
        static readonly int price = 10;
        static readonly List<ItemClass> allowedItemClasses = new();
        static readonly List<IItem> items = new();

        public WarHound(string name, Gender gender) : base(
            name,
            gender,
            soldierType,
            move,
            fight,
            shoot,
            armour,
            will,
            health,
            price,
            allowedItemClasses,
            items)
        { }
    }
}
