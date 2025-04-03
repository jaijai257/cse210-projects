public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience") {}

    public void Run()
    {
        // Display the prompts
        DisplayStartingMessage();
        var prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        ShowCountDown(5);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private void DisplayQuestions()
    {
        var random = new Random();
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }

}