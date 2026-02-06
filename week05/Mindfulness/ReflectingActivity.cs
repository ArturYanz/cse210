public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;



    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time you stood up for someone else.");
        _prompts.Add("Think of a time you helped someone in need.");
        _prompts.Add("Think of a time you overcame a challenge");
        _prompts.Add("Think of a time you were proud of yourself.");
        _prompts.Add("Think of a time you felt supported during a difficult moment.");

        _questions = new List<string>();
        _questions.Add("What made this experience stand out compared to others?");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("What skill helped you get through this experience?");
        _questions.Add("How did thos experience show your resilience?");
        _questions.Add("How can you apply what you learned to future challenges?");
        _questions.Add("What would you do the same or differently next time?");
        _questions.Add("How did you feel during this experience?");
        _questions.Add("What does this experience say about who you are?");


    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        ShowSpinner(4);
        Console.Clear();
        Console.WriteLine("Now that you thought about it, think about the next questions:");
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);
        Console.WriteLine();

        while (DateTime.Now < end)
        {
            string question = GetRandomQuestion();
            DisplayQuestions(question);
            Console.WriteLine();
            ShowSpinner(10);
        }
        Console.WriteLine();
        ShowArrow(3);
        DisplayEndingMessage();
    
    
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine("Consider the following promp:");
        Console.WriteLine();
        Console.WriteLine($"-- {prompt} --");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.ReadLine();
    }
    
    public void DisplayQuestions(string question)
    {
        Console.Write($"> {question}");
    }
}
