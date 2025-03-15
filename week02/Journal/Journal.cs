using System;
 public class Journal
{
    private List<Entry> _entries;
    private Random _random = new Random();
    private string[] _prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string response)
    {
        string prompt = _prompts[_random.Next(_prompts.Length)];
        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
        public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0].Trim();
                    string prompt = parts[1].Trim();
                    string response = parts[2].Trim();
                    Entry entry = new Entry(prompt, response) { Date = date };
                    _entries.Add(entry);
                }
            }
        }
    }
}