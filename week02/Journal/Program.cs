using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Journal newjournal = new Journal();
        
        int _toDo = -1;

        while (_toDo != 3)
        {
            Console.WriteLine("1. Write new");
            Console.WriteLine("2. Display all");
            Console.WriteLine("3. Quit");
            Console.Write("What do you want to do? ");
            _toDo = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (_toDo == 1)
            {
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;

                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();

                newEntry._promptText = prompt;

                Console.Write($"{newEntry._promptText}");
                newEntry._entryText = Console.ReadLine();

                newjournal.AddEntry(newEntry);
                Console.WriteLine("");

            }
            else if (_toDo == 2)
            {
                newjournal.DisplayAll();
                
            }
            else if (_toDo >=4)
            {
                Console.WriteLine("Wrong button. Try Again!");
                Console.WriteLine("");
            }
        }
            
            

        // Entry entry1 = new Entry();
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();
        // entry1._date = dateText;

        // PromptGenerator generator = new PromptGenerator();
        // string prompt = generator.GetRandomPrompt();

        // entry1._promptText = prompt;

        // Console.Write($"{entry1._promptText}");
        // entry1._entryText = Console.ReadLine();


        //entry1.DisplayEntry();



    }
}
