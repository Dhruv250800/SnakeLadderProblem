using System;

class Die1
{
    private Random random;

    public Die1()
    {
        random = new Random();
    }

    public int Roll()
    {
        return random.Next(1, 7);
    }
}

class Game1
{
    private Die die;

    public Game1()
    {
        die = new Die();
    }

    public void CheckOption(int diceRoll)
    {
        int option = die.Roll(); // Generate a random number between 1 and 3 for options

        switch (option)
        {
            case 1:
                Console.WriteLine("No Play - You stay in the same position.");
                break;
            case 2:
                Console.WriteLine("Ladder - You move ahead by " + diceRoll + " positions.");
                break;
            case 3:
                Console.WriteLine("Snake - You move behind by " + diceRoll + " positions.");
                break;
        }
    }
}

