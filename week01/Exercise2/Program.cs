using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("W3LC0ME T0 GR4D3 C4LCULAT0R");
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int score = int.Parse(number);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder = (score % 10);

        if (remainder >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                Console.WriteLine($"Your Grade is {letter}");
            }
            else
            {
                Console.WriteLine($"Your Grade is {letter}+");
            }
            
        }
        else if (remainder <= 3)
        {
            if (letter == "F")
            {
                Console.WriteLine($"Your Grade is {letter}");
            }
            else if (score >= 100)
            {
                Console.WriteLine($"Your Grade is {letter}");
            }
            else
            {
                Console.WriteLine($"Your Grade is {letter}-");
            }
        }
        else
        {
            Console.WriteLine($"Your Grade is {letter}");
        }
        

        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("YOu didn't pass");
        }
   
   
   
   
    }
    



}