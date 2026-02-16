using System;


// Thanks for watching ;-)
// -Arturo 
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("16 Feb 2026", 75, 5);
        activities.Add(run);

        Cycling cycle = new Cycling("20 Jan 2026", 120, 30);
        activities.Add(cycle);

        Swimming swimm = new Swimming("31 Dec 2025", 35, 28);
        activities.Add(swimm);


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}