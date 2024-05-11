using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System;

public class Scripture
{
    private string _reference;
    private List<Word> _words; 
    private List<int> _wordHistory;
    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
        _words = new List<Word>();
        _wordHistory = new List<int>();

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
            int wordIdx = random.Next(0, _words.Count());
            _words[wordIdx].Hide();
            _wordHistory.Add(wordIdx);
        }
    }
    public void ShowPreviousWords(int numberToShow)
    {
        for(int i = numberToShow; i > 0; i--)
        {
            if(_wordHistory.Count > 1)
            {
                _words[_wordHistory[i]].Show();
                _wordHistory.RemoveAt(i);
            }
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