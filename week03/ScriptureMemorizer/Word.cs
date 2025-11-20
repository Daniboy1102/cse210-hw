// This class represents one word of the scripture
public class Word
{
    private string _text;
    private bool _isHidden;

    // Create the word and set it to visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Returns true if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Shows either the real word or underscores if hidden
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);  
        }
        else
        {
            return _text;
        }
    }
}
