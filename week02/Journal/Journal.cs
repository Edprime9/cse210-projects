public class Journal
{
    public List<Entry> _entries = new();
    public void CreateNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Write the text of your entry as a single string.");
        string entryText = Console.ReadLine();
        Entry entry = new(prompt, entryText);
        _entries.Add(entry);

    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFrontFile(string file)
    {
        
    }
}