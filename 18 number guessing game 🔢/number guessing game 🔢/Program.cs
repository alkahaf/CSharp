using System;
public class Program
{

    public static void Main(string[] args)
    {

        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int number;
        int guess = 0;
        int guesses = 0;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);
            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + "-" + max + " :");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + "IS TOO HIGH!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + "IS TOO LOW!");
                }
                guesses++;
            }
            Console.WriteLine("Number: "+ number);
            Console.WriteLine("YOU WIN!!");
            Console.WriteLine("Guesses: " + guesses);
            Console.WriteLine("Would you like to play again (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            
            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for Playing....");
        Console.ReadKey();
    }
}
