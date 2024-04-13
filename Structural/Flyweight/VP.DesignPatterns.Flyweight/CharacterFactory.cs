namespace VP.DesignPatterns.Flyweight;

public class CharacterFactory
{
    private readonly Dictionary<string, ICharacter> _characters = new Dictionary<string, ICharacter>();

    public ICharacter GetCharacter(string name, Sprite sprite)
    {
        if (!_characters.ContainsKey(name))
        {
            _characters[name] = new Character(name, sprite);
        }
        return _characters[name];
    }
}
