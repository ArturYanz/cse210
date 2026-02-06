public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {

        _count = 0;
        _prompts = new List<string>();
        _prompts.Add("Who are the people that you apreciate?");
        _prompts.Add("What are personal strenghts of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are the things you love to do?");

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        GetRandomPrompt();

        List<string> items = GetListFromUser();


        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

    }
    
    public List<string> GetListFromUser()
    {
        List<string> _items = new List<string>();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _items.Add(input);
            _count++;
        } 
        return _items;
    }
}