using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    public readonly int? Capacity = null;

    public Inventory()
    {

    }

    public Inventory(int itemCapacity)
    {
        Capacity = itemCapacity;
    }

    public List<Item> Items = new();

    public bool IsFull => Capacity != null && Items.Count() == Capacity;

    public void AddItem(Item item)
    {
        if (IsFull) { throw new InvalidOperationException(); }

        Items.Add(item);
    }

    public void RemoveItem(Item item) => Items.Remove(item);
}
