public class GoalManagerMenu
{
    private List<Goal> _goals = new List<Goal>();
    public int _score = 0;

    public GoalManagerMenu(Goal goal)
    {
        _goals.Add(goal);
    }

    public GoalManagerMenu() { }

    public void Start() { }
    public void DisplayPlayerInfo() { }

    public static void RecordEvent(List<string> list)
    {
          string nothing = "";
        
        
        int lengthOfList = list.Count;
        Console.WriteLine($"Enter a number,if you have completed a task: Enter {lengthOfList + 1} to exit");
        int isNum = 0;
        while (isNum != lengthOfList + 1){
            Console.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                nothing = list[i];
                Console.WriteLine($"{i + 1} - {nothing}");
            }
            Console.WriteLine($"{lengthOfList + 1} to Exit");
            string num = Console.ReadLine();
            isNum = int.Parse(num);
            for (int i = 0; i < list.Count; i++){
                   
                    if (isNum == i){
                        string indexNum = list[isNum - 1];
                        string addX = $"[X] {indexNum}";
                        list[isNum-1] = addX;
                        
                    }
                    else if (isNum > lengthOfList){
                        break;
                    }

            }
        }
        
    }

    public static void SaveGoals(List<string> data, string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in data)
                {
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Data saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data to file: {ex.Message}");
        }
    }

    public List<(string, string)> LoadGoal(string filePath)
    {
        List<(string, string)> goalDetails = new List<(string, string)>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Assuming the format is "ShortName: Description"
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string shortName = parts[0].Trim();
                        string description = parts[1].Trim();
                        goalDetails.Add((shortName, description));
                    }
                }
            }
            Console.WriteLine("Data loaded from file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data from file: {ex.Message}");
        }
        return goalDetails;
    }
    
}