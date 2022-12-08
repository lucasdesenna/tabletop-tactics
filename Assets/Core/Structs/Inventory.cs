using System.Collections.Generic;

public class Inventory
{
    private readonly int _itemCapacity = 1;

    private readonly List<Item> _items = new();

    public Inventory(int itemCapacity)
    {
        _itemCapacity = itemCapacity;
    }

    public int ItemCapacity => _itemCapacity;

    public List<Item> Items => _items;
}