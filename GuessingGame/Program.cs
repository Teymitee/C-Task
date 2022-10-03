using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            
            int lastInput = 0, userInput, tries = 1, secretNumber = rnd.Next(1,20);

            

           while(tries < 5)
            {
                Console.WriteLine("Guess the secret number between 1 and 20");
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine(secretNumber);

                if (lastInput == userInput)  
                {
                    tries = tries;
                    Console.WriteLine("Entry Same as last, Try Again, you have " + tries + " tries left");
                }
                else if (lastInput != userInput)
                {
                    tries++;
                    if (userInput > secretNumber)
                    {
                        Console.WriteLine("Too Large, Try Again, you have " + (5 - tries) + " tries left");
                    }else if (userInput < secretNumber)
                    {
                        Console.WriteLine("Too Small, Try Again, you have " + (5 - tries) + " tries left");
                    }else
                    {
                        Console.WriteLine("you guessed the secret number");
                        break;
                    }
                }
                
                
            }
           


        }
    }
}