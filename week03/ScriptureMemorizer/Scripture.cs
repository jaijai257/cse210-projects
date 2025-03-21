using System;


public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> _words;

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{Reference}: {string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()))}");
    }

    public bool HideRandomWord()
    {
        var hiddenWords = _words.FindAll(w => w.IsHidden);
        if (hiddenWords.Count >= _words.Count) return false;

        Random random = new Random();
        int index;
        do
        {
            index = random.Next(_words.Count);
        } while (_words[index].IsHidden);

        _words[index].Hide();
        return true;
    }

    
}