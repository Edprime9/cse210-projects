class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Min(3, _words.Count(w => !w.IsHidden)); // Hide up to 3 words at a time

        while (wordsToHide > 0)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden)
            {
                _words[index].Hide();
                wordsToHide--;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference}\n{scriptureText}";
    }
}