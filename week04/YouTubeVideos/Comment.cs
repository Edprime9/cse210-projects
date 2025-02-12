public class Comment
{
    public List<string> _name = new List<string>();
    public List<string> _text = new List<string>();


    public void displayComment()
    {
        for (int i = 0; i < _name.Count; i++)
            {string name = _name[i];
            string comment = _text[i];
            Console.WriteLine($"{name}: {comment}");}
        }
    }
            
    