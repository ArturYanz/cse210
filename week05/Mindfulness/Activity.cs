public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to " + _name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine(" Well done!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");


    }

    public void ShowSpinner(int seconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");


        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerAnimation[i];
            Console.Write(s);
            Thread.Sleep(650);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerAnimation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowArrow(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> arrowAnimation = new List<string>();
        arrowAnimation.Add("- ");


        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = arrowAnimation[i];
            Console.Write(s);
            Thread.Sleep(1000);


            i++;

            if (i >= arrowAnimation.Count)
            {
                i = 0;
            }
        }
        Console.Write(">");
        Thread.Sleep(1000);
    }

    public void ShowDots(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
    }



}