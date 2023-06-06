// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Play();

        Die die = new Die();
        int diceRoll = die.Roll();
        Console.WriteLine("You rolled a " + diceRoll);
        Console.ReadLine();

        Game1 game1 = new Game1();
        int diceRoll1 = 4; // Example dice roll value
        game1.CheckOption(diceRoll1);

        Console.ReadLine();
        Game2 game2 = new Game2();
        game.Play();

        Console.ReadLine();
        Game3 game3 = new Game3();
        game3.Play();
        Game4 game4 = new Game4();
        game4.Play();
        Console.WriteLine("Enter the name of Player 1: ");
        string player1Name = Console.ReadLine();

        Console.WriteLine("Enter the name of Player 2: ");
        string player2Name = Console.ReadLine();

        Game5 game5 = new Game5(player1Name, player2Name);
        game.Play();

        Console.ReadLine();

    }
}
