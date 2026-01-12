using System;

class Program
{
    static void Main(string[] args)
    {

        int guess = -1;

        Random randonGenerator = new Random();
        int number = randonGenerator.Next(1, 101);

        

        while (guess != number)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number < guess)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
            }
            else if (number > guess)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }







    }
}