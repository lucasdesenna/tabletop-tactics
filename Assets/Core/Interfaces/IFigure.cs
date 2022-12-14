using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface IFigure
    {
        public string Name { get; }
        public Gender Gender {get; }
        public int Armour { get; }
        public int Fight { get; }
        public int Health { get; }
        public int Move { get; }
        public int Shoot { get; }
        public int Will { get; }
    }
}
