using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System;

public class Scripture
{
    private string _reference;
    private List<Word> _words; 
    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
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
        Random random = new Random();

        for(int i = 0; i < numberToHide; i++)
        {
            _words[random.Next(0, _words.Count())].Hide();
        }
    }
    public string GetDisplayText()
    {   // combine list by breaking up _word list into individual classes and using the GetDisplayText method
        return $"{_reference}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}"; 
    }
    public bool IsCompletelyHidden()
    {
        // check if any Word in _words contain false
        if(_words.Any(word => !word.IsHidden()))
        {
            return false;
        }
        return true;
    }

}