using SnakeLadderProblem;

class Game5
{
    private Player[] players;
    private int finalPosition;
    private Die die;
    private int diceRollCount;

    public Game5(string player1Name, string player2Name)
    {
        players = new Player[2];
        players[0] = new Player(player1Name);
        players[1] = new Player(player2Name);

        finalPosition = 100;
        die = new Die();
        diceRollCount = 0;
    }

    public void Play()
    {
        Console.WriteLine("Welcome to Snake and Ladder!");
        Console.WriteLine("Reach position 100 to win the game.");

        int currentPlayerIndex = 0;

        while (true)
        {
            Player currentPlayer = players[currentPlayerIndex];

            Console.WriteLine(currentPlayer.Name + ", enter 'r' to roll the dice: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "r")
            {
                int diceRoll = die.Roll();
                diceRollCount++;

                Console.WriteLine(currentPlayer.Name + " rolled a " + diceRoll);

                MovePlayer(currentPlayer, diceRoll);

                Console.WriteLine(currentPlayer.Name + "'s current position is " + currentPlayer.Position);

                if (currentPlayer.Position == finalPosition)
                {
                    Console.WriteLine(currentPlayer.Name + " reached position 100 and won the game!");
                    break;
                }

                if (diceRoll != 6)
                {
                    currentPlayerIndex = (currentPlayerIndex + 1) % 2;
                }
                else
                {
                    Console.WriteLine(currentPlayer.Name + " got a ladder! They get to play again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'r' to roll the dice.");
            }
        }

        Console.WriteLine("Total dice rolls: " + diceRollCount);
        Console.WriteLine("Game Over.");
    }

    private void MovePlayer(Player player, int steps)
    {
        int newPosition = player.Position + steps;

        if (newPosition >= 0)
        {
            if (newPosition <= finalPosition)
            {
                player.Position = newPosition;
            }
            else
            {
                Console.WriteLine("Oops! " + player.Name + " needs " + (finalPosition - player.Position) + " to reach the final position.");
            }

            switch (player.Position)
            {
                case 3:
                    player.Position = 22;
                    Console.WriteLine(player.Name + " found a ladder! Climbing to position 22.");
                    break;
                case 8:
                    player.Position = 15;
                    Console.WriteLine(player.Name + " found a ladder! Climbing to position 15.");
                    break;
                // ... Other snake and ladder cases ...
                case 98:
                    player.Position = 80;
                    Console.WriteLine(player.Name + " encountered a snake. Sliding down to position 80.");
                    break;
            }
        }
        else
        {
            player.Position = 0;
            Console.WriteLine("Oops! " + player.Name + " moved below position 0. Restarting from position 0.");
        }
    }
}