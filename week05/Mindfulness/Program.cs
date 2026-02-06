using System;
// Hi! Im Arturo :D
// I made some "features":
// - If user imput is not a number, a new message is shown.
// - If user imput is a number, but not in the menu range, another message is shown.
// I also added new animations (ShowArrow --->) and ShowDots(...).
// I hope you like this
// Have a great day!
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity act1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing...");
        ReflectingActivity act2 = new ReflectingActivity("Reflecting Activity", "This activity will make you think about times in your life when you have shown strenght and resilience. You will recognize the power you have...");
        ListingActivity act3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area...");


        int toDo = -1;
        while (toDo != 4)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What do you want to do? ");
            string input = Console.ReadLine();


            bool inputValid = int.TryParse(input, out toDo);
            if (!inputValid)
            {
                Console.Clear();
                Console.Write("Please enter a valid number ");
                act1.ShowDots(4);

                Console.WriteLine();

            }
            else if (toDo >= 5 || toDo < 1)
            {
                Console.Clear();
                Console.Write("Enter a number from 1 to 4 please ");
                act1.ShowDots(4);
                Console.WriteLine();
            }
            Console.WriteLine("");

            if (toDo == 1)
            {
                act1.Run();
                Console.Clear();

            }
            else if (toDo == 2)
            {
                act2.Run();
                Console.Clear();

            }
            else if (toDo == 3)
            {
                act3.Run();
                Console.Clear();


            }
        }

        Console.Clear();
        Console.Write("Quiting ");
        act1.ShowDots(5);



    }
}