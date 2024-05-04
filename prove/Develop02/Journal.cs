using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

public class Journal
{
    public List<Entry> _entryList;          // attributes
    public Journal()                        // constructor
    {
        _entryList = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)    // meathods
    {
        _entryList.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine(entry._promptText);
            Console.WriteLine(entry._entryText);
            Console.WriteLine(entry._date);
            Console.WriteLine();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine();
            }
            
        }
        
    }
    public void LoadFromFile(string filename)
    {
        _entryList.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i+=4)
        {
                    // utilize entry class for load
                    Entry entry = new Entry();

                    // load prompt
                    entry._promptText = lines[i];

                    // load entry text
                    entry._entryText  = lines[i+1];

                    // load date
                    entry._date = lines[i+2];

                    // add loaded entry to journal with AddEntry meathod
                    AddEntry(entry);   
        }

        Console.WriteLine($"{filename} loaded!");
    }
    
}