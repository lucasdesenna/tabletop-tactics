public readonly struct FigureProfile
{
    private readonly string _name;

    private readonly Gender _gender;

    public string Name => _name;

    public Gender Gender => _gender;

    public FigureProfile(string name, Gender gender)
    {
        _name = name;
        _gender = gender;
    }
}
