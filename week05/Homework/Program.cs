using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Pedro", "Math");

        Console.WriteLine(assignment1.GetSummary());


        MathAssignment math1 = new MathAssignment("John", "Math", "Section 3", "3-4");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Marta", "History", "The 100 years War");

        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInfo());


    }
}