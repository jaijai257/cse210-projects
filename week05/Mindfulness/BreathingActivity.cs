public class BreathingActivity : Activity
{
    private int _duration;

    public BreathingActivity(): base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    {
        _duration = 60; // Default duration in seconds
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i += 4)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(4);
            Console.WriteLine("Breath out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();

    }
    
}