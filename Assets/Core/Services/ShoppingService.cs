using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Assets.Core.Services
{
    public static class ShoppingService
    {
        private static readonly Dictionary<SoldierType, int> SoldierCostByType = new()
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

        public static int SoldierCost(ISoldier soldier)
        {
            return SoldierCostByType[soldier.SoldierType];
        }

        public static void HireSoldier(IWarband warband, ISoldier soldier)
        {
            int soldierCost = ShoppingService.SoldierCost(soldier);

            if (soldierCost > warband.Funds)
            {
                throw new Exception("Insufficient funds");
            }

            warband.Funds -= soldierCost;
            warband.AddSoldier(soldier);
        }

        public static void DismissSoldier(IWarband warband, ISoldier soldier)
        {
            warband.RemoveSoldier(soldier);
        }

    /*    private static readonly Dictionary<EquipmentType, int> EquipmentCostByType = new()
    {
        { EquipmentType.HAND_WEAPON_1,       300 },
        { EquipmentType.HAND_WEAPON_2,       500 },
        { EquipmentType.HAND_WEAPON_3,       300 },
        { EquipmentType.TWO_HANDED_WEAPON_1, 300 },
        { EquipmentType.TWO_HANDED_WEAPON_2, 200 },
        { EquipmentType.TWO_HANDED_WEAPON_3, 400 },
        { EquipmentType.BOW_1,               300 },
        { EquipmentType.BOW_2,               300 },
        { EquipmentType.CROSSBOW_1,          300 },
        { EquipmentType.CROSSBOW_2,          300 },
        { EquipmentType.DAGGER_1,            300 },
        { EquipmentType.DAGGER_2,            200 },
        { EquipmentType.DAGGER_3,            300 },
        { EquipmentType.LEATHER_ARMOUR,      300 },
        { EquipmentType.MAIL_ARMOUR,         400 },
        { EquipmentType.RING_OF_PROTECTION,  400 },
        { EquipmentType.CLOAK_OF_PROTECTION, 400 },
        { EquipmentType.STAFF_1,             200 },
        { EquipmentType.STAFF_2,             200 },
        { EquipmentType.SHIELD,              400 }
    };

        private static readonly Dictionary<TrinketType, int> TricketCostByType = new()
    {
        { TrinketType.STAFF_OF_POWER_1,          200},
        { TrinketType.STAFF_OF_POWER_2,          350},
        { TrinketType.STAFF_OF_POWER_3,          500},
        { TrinketType.RING_OF_POWER_1,           200},
        { TrinketType.ORB_OF_POWER_1,            350},
        { TrinketType.STAFF_OF_CASTING,          600},
        { TrinketType.BOOTS_OF_SPEED,            300},
        { TrinketType.RING_OF_SLOW_FALL,         200},
        { TrinketType.RING_OF_WILL,              300},
        { TrinketType.RING_OF_TELEPORTATION,     300},
        { TrinketType.GLOVES_OF_STRENGTH,        300},
        { TrinketType.ROBES_OF_ARROW_TURNING,    500},
        { TrinketType.AMULET_OF_RESITANCE,       300},
        { TrinketType.CANDLE_OF_SUMMONING,       200},
        { TrinketType.GLOVES_OF_CASTING,         300},
        { TrinketType.BELT_OF_ANIMAL_REPELLENCE, 200},
        { TrinketType.HORN_OF_DESTRUCTION,       300},
        { TrinketType.FATE_STONE,                300},
        { TrinketType.DRINKING_HORN_OF_HEALING,  250},
        { TrinketType.BANNER_OF_COURAGE,         300}
    };*/


        static public int ApprenticeCost(Wizard wizard) => (wizard.Level - 10) * 10 + 300;

        static public void BuyItem(IWarband warband, IItem item)
        {
            if (warband.Funds < item.Value)
            {
                throw new Exception("Insufficient funds");
            }

            warband.Funds -= item.Value;
            warband.AddItem(item);
        }

        static public void SellItem(IWarband warband, IItem item)
        {
            warband.Funds += (item.Value / 2);
            warband.RemoveItem(item);
        }
    }
}
