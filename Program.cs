using System;

main();
void main()
{
    int numberOfGuesses = 0;
    int secretNumber = 42;
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
                Console.Write("You get 4 guesses. Number of guesses now is ");
                Console.WriteLine(numberOfGuesses);
            }
            if (numberOfGuesses == 4)
            {
                Console.Clear();
                Console.WriteLine("You're out of guesses! Prepare for doom!");

            }
        }
        Guess();
    }
}