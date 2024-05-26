using System.Reflection.Metadata;
using System.Xml;
using System.IO;

/// <summary>
/// This class uses encapsulation to organize and display goals. The class contains
/// all behaviors related to standard op of this program.
/// </summary>
public class GoalManager
{
    // attributes
    private List<Goal> _goals;              // list of goals provided by user
    private int _score;                     // tracks user score
    
    // constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    // methods
    public void Start()                     // start standard op
    {
        // local variables
        int user = 0;                           // variable to store user input. Set to default value 0
        
        while(user != 6)
        {
            DisplayPlayerInfo();                // display score

            Console.WriteLine("Menu Options:"); // display menu options
            Console.WriteLine("  1. Create New Goal\n  2. List Goals  \n  3. Save Goals");
            Console.WriteLine("  4. Load Goals     \n  5. Record Event\n  6. Quit");

            user = GetUserInt("Select a choice from the menu: ");

            if(user == 1)                       // menu logic
            {
                CreateGoal();
            }
            if(user == 2)
            {
                Console.WriteLine("The goals are:");
                ListGoalDetails();
            }
            if(user == 3)
            {
                SaveGoals();
            }
            if(user == 4)
            {
                LoadGoals();
            }
            if(user == 5)
            {
                Console.WriteLine("The goals are:");
                ListGoalNames();
                RecordEvent();
            }
        }

    }
    private void DisplayPlayerInfo()        // display user info (score)
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    private void ListGoalDetails()            // display goals with details
    {
        foreach(Goal goal in _goals)        // places a number before the goal and gets details to display
        {                                   // add one because of zero index
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
    }
    private void ListGoalNames()          // display just goal names
    {                                      
        foreach(Goal goal in _goals)        // places a number before the goal and gets details to display
        {                                   // add one because of zero index
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetStringRepresentation().Split(",")[0]}");
        }                                   // use delimiter just to get goal names
    }
    private void CreateGoal()               // create goal from user input
    {
        // local variables
        int user = 0;
        string name;
        string description;
        int points;
        int target;
        int bonus;
                                            // display goal options
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");

        while(!(user > 0 && user < 4))
        {
            user = GetUserInt("Which type of goal would you like to create? ");
        }
                                            // ui
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();

        points = GetUserInt("What is the amount of points associated with this goal? ");

                                            // logic to get the right constructor
        if(user == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        if(user == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        if(user == 3)
        {                                   // additional attributes for checklist goals
            target = GetUserInt("How many times does this goal need to be accomplished for a bonus? ");
            bonus = GetUserInt("What is the bonus for accomplishing it that many times? ");

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }


    }
    private void RecordEvent()              // check off goal if possible, otherwise just reward points
    {
        int user = 0;

        while(!(user <= _goals.Count() && user > 0))
        {
            user = GetUserInt("Which goal did you accomplish? ");
        }

        if(!_goals[user-1].IsComplete())            // make sure goals can only be completed once
        {
            if(user <= _goals.Count())
            {

                _goals[user - 1].RecordEvent();
                                                    // wow this is fun
                int points = int.Parse(_goals[user - 1].GetStringRepresentation().Split(",")[2]);

                if(_goals[user - 1].GetType().ToString() == "ChecklistGoal")    // handel special case with checklist goals
                {
                    if(_goals[user - 1].IsComplete())
                    {
                        points += int.Parse(_goals[user - 1].GetStringRepresentation().Split(",")[3]);
                    }
                }

                _score += points;
                Console.WriteLine($"Congratulations! You have earned {points} points!\nYou now have {_score} points.");
            }
        }
        else
        {
            Console.WriteLine("That goal is already completed!");
        }
    }
    private void SaveGoals()                // STR goals to text file
    {
        Console.Write("What is the filename for the goal file? ");

        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))    // use file specified by user as output file
        {
            outputFile.WriteLine(_score);
            
            foreach(Goal goal in _goals)
            {
                outputFile.Write($"{goal.GetType()}:");                 // get object name
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    private void LoadGoals()                // LDR goals from text file
    {
        // local variables
        bool exist = false;
        string filename = "";

        while(!exist)                      // protect from non-exist files
        {
            Console.Write("What is the filename for the goal file? ");
            filename = Console.ReadLine();
            
            exist = System.IO.File.Exists(filename);
        }  

        bool skip = true;
        
        _goals.Clear();                     // clear list to avoid duplication

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] substring = line.Split(":");           // split with this delimiter to get object names

            if(!skip)                                       // i can't believe this mess works, but it does
            {
                string[] part = substring[1].Split(",");    // use comma delimiter for second half of substring

                if(substring[0] == "SimpleGoal")            // auto re-instance objects
                {
                    SimpleGoal simpleGoal = new SimpleGoal(part[0], part[1], int.Parse(part[2]));
                    // yes, the program is figuring it out
                    if(bool.Parse(part[3]))
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                }
                if(substring[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(part[0], part[1], int.Parse(part[2]));
                    _goals.Add(eternalGoal);
                }
                if(substring[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(part[0], part[1], int.Parse(part[2]), int.Parse(part[3]), int.Parse(part[4]));
                    // nice
                    for(int i = 0; i < int.Parse(part[5]); i++)
                    {
                        checklistGoal.RecordEvent();
                    }

                    _goals.Add(checklistGoal);
                }
            }
            else
            {
                skip = false;
                _score = int.Parse(substring[0]);           // this only happens once to get the score
            }         
        }
    }
    private int GetUserInt(string prompt = "")   // method protects from unexpected user input
    {
        // local variables
        int user = 0;
        bool protect = true;

        Console.Write(prompt);

        while(protect == true)              // add some protection around the user input here
        {
            try
            {
                user = int.Parse(Console.ReadLine());
                protect = false;
            }
            catch(FormatException)
            {
                Console.Write(prompt);
                protect = true;
            }
        }
        return user;
    }
}