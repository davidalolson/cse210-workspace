public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        for(int i = _duration/10; i > 0; i--)
        {
                Console.Write("\nBreathe in...");
                ShowCountDown(5);

                Console.Write("\nNow breathe out...");
                ShowCountDown(5);

                Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}