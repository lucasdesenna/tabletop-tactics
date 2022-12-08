public sealed class Wizard : Figure
{
    public Wizard(FigureProfile figureProfile,
                  Grimoire grimoire,
                  WizardType wizardType) : base(figureProfile,
                                                new FigureAttributes(6, 2, 0, 10, 4, 14),
                                                new Inventory(5))
    {
        Grimoire = grimoire;
        Type = wizardType;
    }

    public Grimoire Grimoire { get; }

    public WizardType Type { get; }
}
