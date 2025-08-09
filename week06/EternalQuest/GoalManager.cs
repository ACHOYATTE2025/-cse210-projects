public class GoalManager {


//attributes
    private List<Goal> _goals;
    private int _score;

//constructors
    public GoalManager() {
        _goals = new List<Goal>();
        _score = 0;
    }
//setters & Getters
    public void setGoals(List<Goal> goals) {
        this._goals = goals;
    }

    public void setScore(int score) {
        this._score = score;
    }

    public int getScore()
    {
        return this._score;
    }

//methods
public void start()
    {

        int choice = 0;

        bool whiled = false;
        while (!whiled)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");


            try
            {
                Console.Write("Select a choice from the menu:");
                choice = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine("Wrong Entry, Try again ...");


            }


            switch (choice)
            {
                case 1:
                    CreateGoal();
                    ;
                    break;
                case 2:
                    ListGoalDetails();
                    ;
                    break;
                case 3:
                    SaveGoals();
                    ;
                    break;
                case 4:
                    LoadGoals();
                    ;
                    break;
                case 5:
                    RecordEvent();
                    ;
                    break;
                case 6:
                    whiled = true;
                    Console.WriteLine("Bye........");
                    ;
                    break;
                default:
                    Console.Clear();

                    break;
            }
        }
    }
    public void DisplayPlayerInfo() { }
    public void ListGoalNames() { }
    
    //list and show details of differents goals
    public void ListGoalDetails()
    {
        int completedNumber = 0;
        Console.WriteLine("\nThe goals are:");

        string valx = "";
        for (int x = 0; x < _goals.Count; x++)
        {
            if (_goals[x].IsCompleted()) completedNumber += 1;
        }


        for (int i = 0; i < _goals.Count; i++)
        {
            var item = _goals[i];
            valx = item.IsCompleted() ? "X" : " ";
            if (_goals.GetType().FullName == "SimpleGoal")
            {
                valx = item.IsCompleted() ? "X" : " ";
            }
            Console.Write($"{i + 1}. [{valx}] {item.getShortName()} ({item.getDescription()})");


            if (i == _goals.Count - 1 && _goals.Count >= 3)
            {
                Console.Write($" --Currently completed: {completedNumber}/{_goals.Count}");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"\nYou have {this.getScore()} points\n");
    }
    
    //create a goal
    public void CreateGoal()
    {
        int choice = 0;


        bool whiled = false;
        while (!whiled)
        {
            Console.WriteLine("The Type of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternel Goal");
            Console.WriteLine("3. CheckList Goal");


            try
            {
                Console.Write("What type of goals would you like to create? ");
                choice = int.Parse(Console.ReadLine());

            }

            catch (Exception e)
            {
                Console.WriteLine("Wrong Entry, Try again ...");


            }


            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of your Simple Goal: ");
                    string namex = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string descript = Console.ReadLine();
                    Console.Write("What is the amount points associated with the goal? ");
                    string pointx = Console.ReadLine();
                    _goals.Add(new SimpleGoal(namex, descript, pointx));

                    whiled = true;
                    Console.WriteLine("\n");
                    Console.WriteLine($"You have {this.getScore()} point");
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.Write("Enter the name of your Eternal Goal: ");
                    string namei = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string descripti = Console.ReadLine();
                    Console.Write("What is the amount points associated with the goal? ");
                    string pointi = Console.ReadLine();
                    _goals.Add(new EternelGoal(namei, descripti, pointi));
                    whiled = true;
                    Console.WriteLine("\n");
                    Console.WriteLine($"You have {this.getScore()} point");
                    Console.WriteLine("\n");
                    ;
                    break;
                case 3:
                    Console.Write("Enter the name of your  Goal: ");
                    string names = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string descriptis = Console.ReadLine();
                    Console.Write("What is the amount points associated with the goal? ");
                    string pointis = Console.ReadLine();
                    Console.Write("how many times does this goal need to be accomplished for a bonus ? ");
                    int  bonusx =int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing that in many times ? ");
                    int  targetx =int.Parse(Console.ReadLine());
                    _goals.Add(new CheckListGoal(names, descriptis, pointis,bonusx,targetx));
                    whiled = true;
                    Console.WriteLine("\n");
                    Console.WriteLine($"You have {this.getScore()} point");
                    Console.WriteLine("\n");
                    break;
                case 4:
                    this.SaveGoals();
                    break;
                case 5:
                    RecordEvent();
                    ;
                    break;
                case 6:
                    whiled = true;
                    Console.WriteLine("Bye........");
                    ;
                    break;
                default:
                    Console.Clear();

                    break;
            }
        }


    }

    //record event and put iscompleted to true
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {   if (!_goals[i].IsCompleted())
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].getShortName()}");
                }
        }

        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _goals.Count)
        {
            _goals[choice - 1].RecordEvent();//record event
            this._score += int.Parse(_goals[choice - 1].getpoint()); //compute score
            Console.WriteLine("Event recorded.");
            Console.WriteLine(""); }
        else
        {
            Console.WriteLine("Invalid choice.");
            Console.WriteLine("");
        }
    }


    //save goals in a text file
    public void SaveGoals()
    {
        Console.WriteLine("Enter filename to save_in Text file (ex: dragoon.txt): ");
        string fileNamesave = Console.ReadLine();
        try
            {
            using (StreamWriter outputFile = new StreamWriter(fileNamesave))
            {
                foreach (var item in _goals)
                {
                
                outputFile.WriteLine(item.GetType().FullName);
                outputFile.WriteLine(item.getShortName());
                outputFile.WriteLine(item.getDescription());
                outputFile.WriteLine(item.getpoint());
                outputFile.WriteLine(item.IsCompleted());
                outputFile.WriteLine(item.GetDetailsString());
                outputFile.WriteLine(item.GetStringRepresentation());
                outputFile.WriteLine("---");
                }
            }
            Console.WriteLine($"{fileNamesave} saved successfully.");
            }
    catch (Exception ex)
    {
      Console.WriteLine($"Error saving file: {ex.Message}");
    }
     }

    //load text file
    public void LoadGoals()
    {
        Console.Write("Enter filename to load (ex: journal.txt): ");
        string fileNameload = Console.ReadLine();

    try
        {
            if (!File.Exists(fileNameload))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear(); // clear old goals
            string[] lines = File.ReadAllLines(fileNameload);
            int i = 0;

            while (i < lines.Length)
            {
                if (lines[i] == "---")
                {
                    i++;
                    continue;
                }

                string type = lines[i];
                string name = lines[i + 1];
                string desc = lines[i + 2];
                string points = lines[i + 3];
                bool isCompleted = bool.Parse(lines[i + 4]);
                string details = lines[i + 5]; // bonus for CheckListGoal
                string extra = lines[i + 6];   // target for CheckListGoal

                Goal goal = null;

                if (type.Contains("SimpleGoal"))
                {
                    var simpleGoal = new SimpleGoal(name, desc, points);
                    simpleGoal.setIscomplete(isCompleted);
                    goal = simpleGoal;
                }

                else if (type.Contains("EternelGoal"))
                {
                    goal = new EternelGoal(name, desc, points);
                
                }

                else if (type.Contains("CheckListGoal"))
                {
                    int bonus = int.Parse(details);
                    int target = int.Parse(extra);
                    var checkListGoal = new CheckListGoal(name, desc, points, bonus, target);
                    goal = checkListGoal;
                }
            
                else
                {
                    // fallback
                    goal = new Goal(name, desc, points);
                }

                _goals.Add(goal);
                i += 8; // Skip to next goal block
            }

            Console.WriteLine($"{fileNameload} loaded successfully.");
            Console.WriteLine("");
        }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading file: {ex.Message}");
        Console.WriteLine("");
    }
}

    }



