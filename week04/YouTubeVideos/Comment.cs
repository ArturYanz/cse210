// Arturo Yánez - Author

public class Comment
{

    private string _commentAuthor;
    private string _text;

    public Comment(string commentAuthor, string text)
    {
        _commentAuthor = commentAuthor;
        _text = text;

    }
    public override string ToString()
    {
        return $"{_commentAuthor}: {_text}";
    }

}