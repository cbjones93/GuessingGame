using System;

main();
void main()
{
    difficulty();
    void difficulty()
    {
        Console.WriteLine("WELCOME TO THE GUESSING GAME!!!");
           Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Choose a diffculty:");
        Console.WriteLine("1) Easy");
        Console.WriteLine("2) Medium");
        Console.WriteLine("3) Hard");
        Console.WriteLine("4) Cheater");
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
        else if (int.Parse(diffcultySelection) == 4)
        {
            while (true)
            {

                Console.WriteLine("What is the secret number?");
                Console.WriteLine("-------------------------------------");
                string userGuess = Console.ReadLine();


                void Guess()
                {
                    if (secretNumber == int.Parse(userGuess))
                    {
                        Console.WriteLine("WOW! You're a mindreader! (although you cheated)");
                        Console.WriteLine("---------------------------------------------");
                        main();
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
                        Console.Write("Number of guesses now is ");
                        Console.WriteLine(numberOfGuesses);
                    }
                }

                Guess();

            }
        }
        else
        {
            Console.WriteLine("Please select a number 1-4 to play the game");
        }
        difficulty();
    }
}
