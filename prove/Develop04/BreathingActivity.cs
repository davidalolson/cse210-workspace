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
                Console.Clear();
                Console.Write("\nBreathe in...       ");
                ShowBreathingGuide(GLOBAL_SYNC_DELAY, true);
                Console.Clear();
                Console.Write("\nNow breathe out...  ");
                ShowBreathingGuide(GLOBAL_SYNC_DELAY, false);

                Console.WriteLine();
        }
        DisplayEndingMessage();
    }
    private void ShowBreathingGuide(int seconds, bool breathIn)
    {
        string fullBlock = "█";
        string halfBlock = "▌";

        if(breathIn)
        {
            for(int i = 0; i < seconds*2; i++)
            {
                Console.Write(halfBlock);  

                Thread.Sleep(250);

                Console.Write("\b" + fullBlock);

                Thread.Sleep(250);
            }
        }
        else
        {
            for(int i = 0; i < seconds*2; i++)
            {
                Console.Write(halfBlock);  
                Console.Write("\b" + fullBlock);
            }

            for(int i = seconds*2; i > 0; i--)
            {
                Console.Write("\b" + halfBlock); 

                Thread.Sleep(250);

                Console.Write("\b \b"); 

                Thread.Sleep(250);
            }
        }
        
    


        





    }
}