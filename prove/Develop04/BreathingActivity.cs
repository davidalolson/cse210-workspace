// child class
public class BreathingActivity : Activity
{
    // use base constructor
    public BreathingActivity(string name, string description) : base(name, description) {}
    
    //methods
    public void Run()
    {
        DisplayStartingMessage();

        for(int i = _duration/10; i > 0; i--)
        {
                Console.Clear();    // clear for consitancy with the bars
                Console.Write("\nBreathe in...       ");
                ShowBreathingGuide(GLOBAL_SYNC_DELAY, true);    // use a breathing guide graphic
                Console.Clear();
                Console.Write("\nNow breathe out...  ");
                ShowBreathingGuide(GLOBAL_SYNC_DELAY, false);

                Console.WriteLine();
        }

        DisplayEndingMessage();
    }
    private void ShowBreathingGuide(int seconds, bool breathIn)
    {
        // use graphics characters to simulate a moving bar
        string fullBlock = "█";
        string halfBlock = "▌";

        if(breathIn)
        {
            for(int i = 0; i < seconds*2; i++)
            {
                Console.Write(halfBlock);  // use halfblock for more organic motion

                Thread.Sleep(250);

                Console.Write("\b" + fullBlock);

                Thread.Sleep(250);
            }
        }
        else
        {
            for(int i = 0; i < seconds*2; i++)  // instantly fill the bar to whatever length is needed
            {
                Console.Write(halfBlock);  
                Console.Write("\b" + fullBlock);
            }

            for(int i = seconds*2; i > 0; i--)  // delete charecters sequentialy from bar
            {
                Console.Write("\b" + halfBlock); // place halfBlock where needed

                Thread.Sleep(250);

                Console.Write("\b \b"); 

                Thread.Sleep(250);
            }
        }
        
    


        





    }
}