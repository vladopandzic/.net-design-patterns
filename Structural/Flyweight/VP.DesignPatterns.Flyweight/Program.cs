namespace VP.DesignPatterns.Flyweight;

internal class Program
{

    static void Main(string[] args)
    {
        Game game = new Game();

        Sprite playerSprite = new Sprite("player_sprite.png");
        Sprite enemySprite = new Sprite("enemy_sprite.png");
        Sprite npcSprite = new Sprite("npc_sprite.png");

        game.AddCharacter("Player1", 10, 20, playerSprite);

        game.AddCharacter("Enemy", 30, 40, enemySprite);

        game.AddCharacter("Player1", 70, 80, playerSprite); // Reusing the "Player" character

        game.AddCharacter("NPC", 70, 80, npcSprite);

        game.Render();

        Console.ReadKey();
    }
}
