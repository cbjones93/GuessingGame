using System;

main();
void main()
{
    int numberOfGuesses = 0;
    int secretNumber = new Random().Next(1,100);
    while (numberOfGuesses < 4)
    {

        Console.WriteLine("What is the secret number?");
        Console.WriteLine("-------------------------------------");
        string userGuess = Console.ReadLine();


        void Guess()
        {
            if (secretNumber == int.Parse(userGuess))
            {
                Console.WriteLine("WOW! You're a mindreader!");
                numberOfGuesses = 5;

            }
            else
            {
                Console.WriteLine("NOPE, Try again!");
                numberOfGuesses++;
                Console.Write("Number of guesses now is ");
                Console.WriteLine(numberOfGuesses);
                Console.Write("Guesses left: ");
                Console.WriteLine(4-(numberOfGuesses));
            }
            if (numberOfGuesses == 4)
            {
                Console.Clear();
                Console.Write("The secret number was ");
                Console.WriteLine(secretNumber);
                Console.WriteLine("You're out of guesses! Prepare for doom!");

            }
        }
        Guess();
    }
}