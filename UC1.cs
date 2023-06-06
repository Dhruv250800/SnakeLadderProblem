using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    class Player
    {
        public int Position { get; set; }
        public string Name { get; internal set; }

        public Player(string player1Name)
        {
            Position = 0;
        }

        public Player()
        {
        }
    }

    class Game
    {
        private Player player;
        private int finalPosition;
        private Random random;

        public Game()
        {
            player = new Player();
            finalPosition = 100;
            random = new Random();
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
                    int diceRoll = random.Next(1, 7);
                    Console.WriteLine("You rolled a " + diceRoll);

                    MovePlayer(diceRoll);

                    if (player.Position == finalPosition)
                    {
                        Console.WriteLine("Congratulations! You reached position 100 and won the game!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'r' to roll the dice.");
                }
            }

            Console.WriteLine("Game Over.");
        }

        private void MovePlayer(int steps)
        {
            int newPosition = player.Position + steps;

            if (newPosition <= finalPosition)
            {
                player.Position = newPosition;
                Console.WriteLine("Your current position is " + player.Position);

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
                Console.WriteLine("Oops! You need " + (finalPosition - player.Position) + " to reach the final position.");
            }
        }

    }
}
