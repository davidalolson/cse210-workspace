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
    public void LoadFromFile(string file)
    {

    }
    
}