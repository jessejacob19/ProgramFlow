using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourNumber = 10;

            Console.WriteLine("Please guess the number");
            string answer = Console.ReadLine();
            int guessNumber = 0;
            Int32.TryParse(answer, out guessNumber);

            if (guessNumber == ourNumber)
            {
                Console.WriteLine("Correct! Well Done!");
            } else if (guessNumber > ourNumber)
            {
                Console.WriteLine("Too High!!");
            } else if(guessNumber < ourNumber) {
                Console.WriteLine("Too Low!!");
            } else
            {
                Console.WriteLine("Sorry, thats wrong!");
            }

            Console.WriteLine("Press any key to end the program");
            Console.ReadLine();
        }
    }
}
