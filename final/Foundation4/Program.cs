using System;

class Program
{
    static void Main(string[] args)
    {
        /********************************
            [ACTIVITY] <Running>
            September 29, 1996
            
            64-minutes
        *********************************/
        Running running = new Running("September 29, 1996", 64, 5);

        /********************************
            [ACTIVITY] <Bicycling>
            November 21, 1990
            
            16-minutes
        *********************************/
        Bicycling bicycling = new Bicycling("November 21, 1990", 16, 16.863);

        /********************************
            [ACTIVITY] <Swimming>
            September 27, 1986
            
            8-minutes
        *********************************/
        Swimming swimming = new Swimming("September 27, 1986", 8, 12);

        // place all activities in the same list
        List<Activity> activities = new List<Activity>([running, bicycling, swimming]);

        // display each activity summary
        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}