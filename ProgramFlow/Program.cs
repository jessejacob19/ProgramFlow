using System;

namespace ProgramFlow
{
    class Program
    {
        static int GetGuess()
        {
            int result = 0;
            Console.WriteLine("Please guess the number");
            string answer = Console.ReadLine();
            Int32.TryParse(answer, out result);

            return result;
        }
        static void Main(string[] args)
        {
            int ourNumber = 10;
            int guessNumber = 0;
            


            while (ourNumber != guessNumber)
            {
                guessNumber = GetGuess();
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
            }
            

            Console.WriteLine("Press any key to end the program");
            Console.ReadLine();
        }
    }
}
