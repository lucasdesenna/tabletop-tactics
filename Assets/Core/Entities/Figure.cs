public abstract class Figure
{
    public Figure(FigureProfile profile,
                  FigureAttributes attributes,
                  Inventory inventory)
    {
        Profile = profile;
        Attributes = attributes;
        Inventory = inventory;
    }

    public FigureProfile Profile { get; }

    public FigureAttributes Attributes { get; }

    public Inventory Inventory { get; }
}
