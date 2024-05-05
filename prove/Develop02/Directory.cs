public class Directory
{
    public List<string> _directoryList;     // attributes
    private int skipFlag = 0;   // use to check if file already exsists
    public Directory()                      // constructor
    {
        _directoryList = new List<string>();
    }
    private void AddTempDirectory(string filename)  // temporary storage for directory
    {
        _directoryList.Add(filename);
    }
    public void AddToDirectory(string filename)     // method loads from file then appends new data
    {
        _directoryList.Clear();
        
        string[] lines = System.IO.File.ReadAllLines("Directory.txt"); // load from file

        for (int i = 0; i < lines.Length; i++)
        {
            AddTempDirectory(lines[i]);  
        }

        using (StreamWriter outputFile = new StreamWriter("Directory.txt"))
        {
            foreach (string file in _directoryList)
            {
                outputFile.WriteLine(file);
                if (filename == file)   // if file is already saved, skip
                {
                    skipFlag = 1;
                }
            }
            if (skipFlag != 1)
            {
                outputFile.WriteLine(filename); // append user input
                AddTempDirectory(filename);     // add most recent file
                skipFlag = 0;   // reset skip flag
            }
        }
    }
    public void Display()
    {
        foreach (string file in _directoryList)
        {
            Console.WriteLine(file);
        }
    }

}