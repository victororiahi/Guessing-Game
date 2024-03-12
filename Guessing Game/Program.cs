internal class Program
{
    private static void Main(string[] args)
    {
            Random random = new Random();
            int secretNumber = random.Next(1, 21);


        // Display the secret number (for testing purposes)
        Console.WriteLine($"Secret Number: {secretNumber}");

        // Number of chances the user has
        int chances = 3;

            for (int i = 0; i <= 3; i++)
            {
                Console.Write($"Guess the number (between 1 and 20): ");

                if (int.TryParse(Console.ReadLine(), out int userGuess))

                {
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You won the game.");
                    return;
                }


                else if (userGuess < secretNumber)
                {
                    Console.WriteLine($"Incorrect guess. Your guess is lower than the secret number. \n \n Chances left: {chances}");
                    chances--;
                }


                else if (userGuess > secretNumber)
                {
                    Console.WriteLine($"Incorrect guess. Your guess is higher than the secret number. \n Chances left: {chances}");
                    chances--;
                }
                   
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement i to allow the user to guess again in the same round
                }
            }

            Console.WriteLine($"You lost. The correct number was {secretNumber}");
    }
}

