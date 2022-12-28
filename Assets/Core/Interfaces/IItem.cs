using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        string Description { get; }
        ItemClass ItemClass { get; }
        ItemType ItemType { get; }
        int Price { get; }

        void ItemEffect(IFigure ownerFigure, IFigure targetFigure, IGameboard gameboard);
    }
}
