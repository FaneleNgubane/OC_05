using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int winNumber = rand.Next(1, 100);
        int guess = 0;
        int numOfGuess = 0;
        bool winner = false;
        int maxGuess = 10;
       

        
        while (winner == false)
        {

            if (numOfGuess > maxGuess - 1)
            {
                Console.WriteLine("You have reached the max number of guesses: " + maxGuess);
                break;
            }

                Console.WriteLine("Enter a number:");
                guess = Convert.ToInt32(Console.ReadLine());
               
              
            if (guess > winNumber)
            {
                numOfGuess++;
                Console.WriteLine("Guess is too high, try again. ");
                Console.WriteLine("The number of guesses is " + numOfGuess);
            }

            else if (guess < winNumber)
            {
                numOfGuess++;
                Console.WriteLine("Guess is too low, try again. ");
                Console.WriteLine("The number of guesses is " + numOfGuess);
            }

            else if (guess == winNumber)
            {
                numOfGuess++;
                Console.WriteLine("You win! Good job. ");
                Console.WriteLine("The number of guesses is " + numOfGuess);
                winner = true;

            }
        }
    }
}