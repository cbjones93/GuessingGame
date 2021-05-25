using System;

main();
void main()
{
    difficulty();
    void difficulty()
    {
        Console.WriteLine("Choose a diffculty:");
        Console.WriteLine("1) Easy");
        Console.WriteLine("2) Medium");
        Console.WriteLine("3) Hard");
        string diffcultySelection = Console.ReadLine();
        int numberOfGuesses = 0;
        int secretNumber = new Random().Next(1, 100);
        if (int.Parse(diffcultySelection) == 1)
        {
            while (numberOfGuesses < 8)
            {

                Console.WriteLine("What is the secret number?");
                Console.WriteLine("-------------------------------------");
                string userGuess = Console.ReadLine();


                void Guess()
                {
                    if (secretNumber == int.Parse(userGuess))
                    {
                        Console.WriteLine("WOW! You're a mindreader!");
                        numberOfGuesses = 10;

                    }
                    else
                    {
                        if (int.Parse(userGuess) > secretNumber)
                        {
                            Console.WriteLine("NOPE, Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("NOPE, Your guess was too low!");
                        }
                        numberOfGuesses++;
                        Console.Write("Number of guesses now is ");
                        Console.WriteLine(numberOfGuesses);
                        Console.Write("Guesses left: ");
                        Console.WriteLine(8 - (numberOfGuesses));
                    }
                    if (numberOfGuesses == 8)
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
        else if (int.Parse(diffcultySelection) == 2)
        {
            while (numberOfGuesses < 6)
            {

                Console.WriteLine("What is the secret number?");
                Console.WriteLine("-------------------------------------");
                string userGuess = Console.ReadLine();


                void Guess()
                {
                    if (secretNumber == int.Parse(userGuess))
                    {
                        Console.WriteLine("WOW! You're a mindreader!");
                        numberOfGuesses = 10;

                    }
                    else
                    {
                        if (int.Parse(userGuess) > secretNumber)
                        {
                            Console.WriteLine("NOPE, Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("NOPE, Your guess was too low!");
                        }
                        numberOfGuesses++;
                        Console.Write("Number of guesses now is ");
                        Console.WriteLine(numberOfGuesses);
                        Console.Write("Guesses left: ");
                        Console.WriteLine(6 - (numberOfGuesses));
                    }
                    if (numberOfGuesses == 6)
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
        else if (int.Parse(diffcultySelection) == 3)
        {
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
                        numberOfGuesses = 10;

                    }
                    else
                    {
                        if (int.Parse(userGuess) > secretNumber)
                        {
                            Console.WriteLine("NOPE, Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("NOPE, Your guess was too low!");
                        }
                        numberOfGuesses++;
                        Console.Write("Number of guesses now is ");
                        Console.WriteLine(numberOfGuesses);
                        Console.Write("Guesses left: ");
                        Console.WriteLine(4 - (numberOfGuesses));
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
        else
        {
            Console.WriteLine("Invalid Entry Please Choose A Number Between 1-3");
            difficulty();
        }
    }
}
