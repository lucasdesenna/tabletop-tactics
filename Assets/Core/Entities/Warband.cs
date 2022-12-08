public class Warband
{
    public Warband (Wizard wizard) {
        Wizard = wizard;
    }

    public readonly Wizard Wizard;

    public Apprentice Apprentice { get; set; }

    public Inventory Inventory { get; set; }
}
