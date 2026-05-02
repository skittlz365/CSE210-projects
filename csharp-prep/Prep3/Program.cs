using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgainFlag = true;
        while(playAgainFlag == true)
        {
            Console.WriteLine("Welcome to the random number game!");
            int secretNumber = Random.Shared.Next(100);

            bool flag = true;
            while(flag == true)
            {
                Console.Write("Enter a guess: ");
                string userGuessStr = Console.ReadLine();
                int userGuessInt = int.Parse(userGuessStr);

                if(userGuessInt > secretNumber)
                {
                    Console.WriteLine("Too high. Try a lower number.");
                }

                else if(userGuessInt < secretNumber)
                {
                    Console.WriteLine("Too low. Try a higher number.");
                }

                else if(userGuessInt == secretNumber)
                {
                    Console.WriteLine("That is correct!");
                    flag = false;
                }
            }

            Console.Write("Would you like to play again? (Enter yes or no): ");
            string playAgain = Console.ReadLine();

            if(playAgain.ToLower() == "no")
            {
                playAgainFlag = false;
            } 
        }
    }
}