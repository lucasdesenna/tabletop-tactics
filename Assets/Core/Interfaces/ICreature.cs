using Assets.Core.Enums;

namespace Assets.Core.Interfaces
{
    public interface ICreature : IWithAttributes, IWithTags
    {
        string Name { get; }
        string Description { get; }
        CreatureCategory CreatureCategory { get; }
        CreatureType CreatureType { get; }
    }
}
