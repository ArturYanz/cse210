using System;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

// Hi! Im Arturo, I hope you like my little program
// I added some little UX effects, while displaying the text, with \n\n and Trim()
// Also, I added some logic for the program to know which words are already hidden, for it to 
// avoid them and not hide them again

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (scripture.IsCompletelyHidden() == false)
        {

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter Key to continue or type 'quit' to stop the program");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "quit")
            {
                break;
            }
            else
            {

                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}