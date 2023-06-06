class Game4
{
    private Player player;
    private int finalPosition;
    private Die die;
    private int diceRollCount;

    public Game4()
    {
        player = new Player();
        finalPosition = 100;
        die = new Die();
        diceRollCount = 0;
    }

    public void Play()
    {
        Console.WriteLine("Welcome to Snake and Ladder!");
        Console.WriteLine("Reach position 100 to win the game.");

        while (player.Position < finalPosition)
        {
            Console.WriteLine("Enter 'r' to roll the dice: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "r")
            {
                int diceRoll = die.Roll();
                diceRollCount++;

                Console.WriteLine("You rolled a " + diceRoll);

                MovePlayer(diceRoll);

                Console.WriteLine("Your current position is " + player.Position);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'r' to roll the dice.");
            }
        }

        Console.WriteLine("Congratulations! You reached position 100 and won the game!");
        Console.WriteLine("Total dice rolls: " + diceRollCount);
        Console.WriteLine("Game Over.");
    }

    private void MovePlayer(int steps)
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
                Console.WriteLine("Oops! You need " + (finalPosition - player.Position) + " to reach the final position.");
            }

            switch (player.Position)
            {
                case 3:
                    player.Position = 22;
                    Console.WriteLine("You found a ladder! Climb to position 22.");
                    break;
                case 8:
                    player.Position = 15;
                    Console.WriteLine("You found a ladder! Climb to position 15.");
                    break;
                // ... Other snake and ladder cases ...
                case 98:
                    player.Position = 80;
                    Console.WriteLine("Oh no! You encountered a snake. Slide down to position 80.");
                    break;
            }
        }
        else
        {
            player.Position = 0;
            Console.WriteLine("Oops! You moved below position 0. Restarting from position 0.");
        }
    }
}