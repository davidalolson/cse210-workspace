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
        
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }
    
}