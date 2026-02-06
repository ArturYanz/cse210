public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    
    public void Run()
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(4);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.WriteLine();
            Console.Write("Breathe in ");
            ShowDots(3);
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out ");
            ShowDots(3);
            ShowCountDown(5);
            Console.WriteLine();

        }
        Console.WriteLine();
        ShowArrow(3);
        DisplayEndingMessage();
        Thread.Sleep(5000);


    }
}