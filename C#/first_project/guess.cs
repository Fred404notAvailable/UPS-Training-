using System;

public class Guess {

    private int CalcScore(int triesUsed) {
        return Math.Max(0, 200 - (triesUsed * 10));
    }

    public int GuessNumber() {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);
        const int MAX = 20;
        int count = 0;
        bool guessed = false;

        Console.WriteLine("--- Guess the Number ---");
        Console.WriteLine("Guess a number between 1 and 100. You have 20 attempts.\n");

        while (count < MAX) {
            Console.WriteLine("Attempt: " + (count + 1) + "/" + MAX);
            Console.Write("Enter your guess: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess) || guess < 1 || guess > 100) {
                Console.WriteLine("Invalid input. Enter a number between 1 and 100.\n");
                continue;
            }

            count++;

            if (guess == randomNumber) {
                guessed = true;
                Console.WriteLine("Correct! The number was: " + randomNumber);
                Console.WriteLine("You guessed it in " + count + " attempt(s).");
                Console.WriteLine("Score: " + CalcScore(count) + " / 200\n");
                break;
            } else if (guess < randomNumber) {
                Console.WriteLine("Too low.\n");
            } else {
                Console.WriteLine("Too high.\n");
            }
        }

        if (!guessed) {
            Console.WriteLine("Out of attempts. The number was: " + randomNumber + "\n");
        }

        return count;
    }
}

public class Game_Main {
    public static void Main(string[] args) {
        int grandTotalScore = 0;
        int roundCount = 0;
        string answer;

        do {
            roundCount++;
            Console.WriteLine("Round " + roundCount + ":\n");

            Guess g = new Guess();
            int triesUsed = g.GuessNumber();

            int score = Math.Max(0, 200 - (triesUsed * 10));
            grandTotalScore += score;

            Console.WriteLine("Round score: " + score);
            Console.WriteLine("Total score so far: " + grandTotalScore + "\n");

            Console.Write("Play another round? (y/n): ");
            answer = Console.ReadLine();
            Console.WriteLine();

        } while (answer != null && answer.Trim().ToLower() == "y");

        Console.WriteLine("--- Game Over ---");
        Console.WriteLine("Rounds played: " + roundCount);
        Console.WriteLine("Grand total score: " + grandTotalScore);
        Console.WriteLine("Average score: " + (grandTotalScore / roundCount));
        Console.WriteLine("Thanks for playing.");
    }
}
