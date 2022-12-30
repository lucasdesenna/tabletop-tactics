using System.Collections.Generic;
using Assets.Core.Enums;


namespace Assets.Core.Interfaces
{
    public interface IWithTags
    {
        HashSet<Tag> Tags { get; }
    }
}