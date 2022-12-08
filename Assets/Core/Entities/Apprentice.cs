public sealed class Apprentice : Figure
{
    public Apprentice(FigureProfile profile,
                  Grimoire grimoire,
                  WizardType wizardType) : base(profile,
                                                new FigureAttributes(6, 0, -2, 10, 2, 10),
                                                new Inventory(4))
    {
        Grimoire = grimoire;
        Type = wizardType;
    }

    public Grimoire Grimoire { get; }

    public WizardType Type { get; }
}
