using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface IFigure : IWithAttributes, IWithTags
    {
        string Name { get; }
        Gender Gender { get; }
        FigureState State { get; set; } 
    }
}
