public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<string> _comments = new List<string>();

    public Video()
    {
        
    }

    public Video(string setTitle, string setAuthor, double setLength)
    {
        _title=setTitle;
        _author=setAuthor;
        _length=setLength;
    }

    public int TotalComments()
    {
        int comments = _comments.Count;
        return comments;
    }

    public void Display()
    {   
        Console.WriteLine($"Title: {_title}, Author: {_author}, Duration: {_length}, Total Comment: {TotalComments()} ");

    }    
}