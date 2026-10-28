using System;

public class Code {

    private int[] GetDigits(int number) {
        int[] digits = new int[4];
        for (int i = 3; i >= 0; i--) {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    private int CalcScore(int attemptsUsed) {
        return Math.Max(0, 1000 - (attemptsUsed - 1) * 100);
    }

    public int TrySolve() {
        Random rand = new Random();
        const int MAX = 10;
        int attemptsUsed = MAX;
        bool cracked = false;

        Console.WriteLine("--- Secret Code Breaker ---");
        Console.WriteLine("Guess the secret 4-digit code. You have 10 attempts.\n");

        int randomNumber = rand.Next(1000, 10000);
        int[] secretDigits = GetDigits(randomNumber);
        int count = 0;

        while (count < MAX) {
            Console.WriteLine("Attempt: " + (count + 1) + "/" + MAX);
            Console.Write("Enter your 4-digit guess: ");

            string input = Console.ReadLine();

            if (input == null || input.Length != 4 || !int.TryParse(input, out int guess) || guess < 1000) {
                Console.WriteLine("Invalid input. Enter a 4-digit number (1000-9999).\n");
                continue;
            }

            count++;
            int[] guessDigits = GetDigits(guess);

            int correctPos = 0;
            for (int i = 0; i < 4; i++) {
                if (guessDigits[i] == secretDigits[i])
                    correctPos++;
            }

            if (guess == randomNumber) {
                cracked = true;
                attemptsUsed = count;
                Console.WriteLine("Correct! The secret code was: " + randomNumber);
                Console.WriteLine("You solved it in " + attemptsUsed + " attempt(s).");
                Console.WriteLine("Score: " + CalcScore(attemptsUsed) + " / 1000\n");
                break;
            } else {
                Console.WriteLine("Correct digits in correct position: " + correctPos + "/4\n");
            }
        }

        if (!cracked) {
            Console.WriteLine("Out of attempts. The secret code was: " + randomNumber + "\n");
        }

        return attemptsUsed;
    }
}

public class Code_prg {
    public static void Main(string[] args) {
        int grandTotalScore = 0;
        int roundCount = 0;
        string answer;

        do {
            roundCount++;
            Console.WriteLine("Round " + roundCount + ":\n");

            Code game = new Code();
            int attemptsUsed = game.TrySolve();

            int score = Math.Max(0, 1000 - (attemptsUsed - 1) * 100);
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
