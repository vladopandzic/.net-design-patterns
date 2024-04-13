namespace VP.DesignPatterns.Flyweight;

public class Game
{
    private readonly CharacterFactory _characterFactory = new CharacterFactory();
    private readonly List<CharacterContext> _characterPositions = new List<CharacterContext>();

    public void AddCharacter(string name, int x, int y, Sprite sprite)
    {
        _characterPositions.Add(new CharacterContext(name, x, y, sprite));
    }

    public void Render()
    {

        foreach (CharacterContext context in _characterPositions)
        {
            ICharacter character = _characterFactory.GetCharacter(context.Name, context.Sprite);
            character.Display(context.X, context.Y);
        }
    }
}
