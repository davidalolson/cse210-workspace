using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private string _reference;
    private List<Word> _words; 
    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>();

        string[] wordArray = text.Replace(" ", "$").Split("$", StringSplitOptions.RemoveEmptyEntries); // create delimiter and split
        
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }

}