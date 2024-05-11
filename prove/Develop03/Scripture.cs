using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System;

public class Scripture
{
    // attributes
    private string _reference;
    private List<Word> _words; 
    private List<int> _wordHistory;     // use this list to keep track of words that have been hidden
    private int wordIdx;                // use with comparisons
    // constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
        _words = new List<Word>();
        _wordHistory = new List<int>();

        // break up long string into word array to put in word class
        string[] wordArray = text.Replace(" ", "$").Split("$", StringSplitOptions.RemoveEmptyEntries); // create delimiter and split
        
        foreach (string wordText in wordArray)
        {  
            // put words in individual classes
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    // methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for(int i = 0; i < numberToHide; i++)
        {
            // use do while loop to avoid duplicate numbers
            do
            {
                wordIdx = random.Next(0, _words.Count());
            }  while(_wordHistory.Contains(wordIdx) && !IsCompletelyHidden() && _wordHistory.Count < _words.Count());   // infinate loop protection
            if(_wordHistory.Count < _words.Count()) // restrict _wordHistory length to the amount of words
            {
                _words[wordIdx].Hide();
                _wordHistory.Add(wordIdx);
            }
           
        }
    }
    public void ShowPreviousWords(int numberToShow)
    {
        // use decrementing for loop
        for(int i = numberToShow; i > 0; i--)
        {
            if(_wordHistory.Count > 1)
            {
                _words[_wordHistory[i]].Show();
                _wordHistory.RemoveAt(i);   // remove from _wordHistory after use
            }
        }
        if(_wordHistory.Count == 1)
        {
             _words[_wordHistory[0]].Show();
             _wordHistory.RemoveAt(0);   
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