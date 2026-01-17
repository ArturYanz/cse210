using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Hi Im Arturo Yánez, this is my project :D
// I added some extra features:
// 1. Input validation using int.TryParse to prevent crashes
// 2. Validation to ensure the menu option is between 1 and 5
// 3. Informative messages when saving, loading or quitting the program

class Program
{
    static void Main(string[] args)
    {
        Journal newjournal = new Journal();

        int toDo = -1;
        Console.WriteLine("------------Dear Diary (1.1)------------");
        while (toDo != 5)
        {
            Console.WriteLine("     1. Write new");
            Console.WriteLine("     2. Display all");
            Console.WriteLine("     3. Save file");
            Console.WriteLine("     4. Load file");
            Console.WriteLine("     5. Quit");
            Console.Write("        What do you want to do? ");
            string input = Console.ReadLine();


            bool inputValid = int.TryParse(input, out toDo);
            if (!inputValid)
            {
                Console.WriteLine("Please enter a valid number");
                Console.WriteLine("");
                continue;
            }
            else if (toDo >= 6 || toDo < 1)
            {
                Console.WriteLine("Enter a number from 1 to 5 please...");
                Console.WriteLine("");
                continue;
            }
            Console.WriteLine("");

            if (toDo == 1)
            {
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;

                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();

                newEntry._promptText = prompt;

                Console.Write($"{newEntry._promptText} ");
                newEntry._entryText = Console.ReadLine();

                newjournal.AddEntry(newEntry);
                Console.WriteLine("");

            }
            else if (toDo == 2)
            {
                newjournal.DisplayAll();

            }
            else if (toDo == 3)
            {
                Console.Write("Give a name to the file: ");
                string file = Console.ReadLine();


                Console.WriteLine("Saving File...");
                newjournal.SaveToFile(file);


            }
            else if (toDo == 4)
            {
                Console.Write("What is the name of the file you want to load? ");
                string file = Console.ReadLine();

                Console.WriteLine("Loading File...");
                Console.WriteLine("");
                newjournal.LoadFromFile(file);
            }



            
        }


        Console.WriteLine("Quiting...");
        Console.WriteLine("----------------------------------------");


    }
}
