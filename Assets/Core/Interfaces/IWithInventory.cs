using Assets.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Core.Interfaces
{
    public interface IWithInventory
    {
        int? ItemCapacity { get; }

        List<IItem> Items { get; }

        bool IsFull { get => ItemCapacity != null && Items.Count() == ItemCapacity; }

        void AddItem(IItem item)
        {
            if (IsFull) { throw new InvalidOperationException(); }

            Items.Add(item);
        }

        void RemoveItem(IItem item) => Items.Remove(item);
    }
}
