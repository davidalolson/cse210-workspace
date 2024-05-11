public class Word
{
    private string _text;
    private string _ogText; // save origional text
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _ogText = text;
        _isHidden = false;
    }
    public void Hide()
    {   // convert word into _____ by splicing this line
        _text = "________________________".Substring(0,_text.Length);
        _isHidden = true;
    }
    public void Show()
    {
        _text = _ogText;
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}