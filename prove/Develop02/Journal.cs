using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

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
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }
    
}