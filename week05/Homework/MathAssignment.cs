using System.Net;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string author, string title, string textbookSection, string problems) : base (author, title)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }




}