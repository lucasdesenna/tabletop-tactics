public readonly struct FigureAttributes
{
    private readonly int _armour;
    private readonly int _fight;
    private readonly int _health;
    private readonly int _move;
    private readonly int _shoot;
    private readonly int _will;

    public int Armour => _armour;

    public int Fight => _fight;

    public int Health => _health;

    public int Move => _move;

    public int Shoot => _shoot;

    public int Will => _will;

    public FigureAttributes(int move,
                            int fight,
                            int shoot,
                            int armour,
                            int will,
                            int health)
    {
        _armour = armour;
        _fight = fight;
        _health = health;
        _move = move;
        _shoot = shoot;
        _will = will;
    }
}
