using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface ISoldier : IFigure, IWithInventory
    {
        SoldierType SoldierType { get; }

        int Cost { get; }
    }
}
