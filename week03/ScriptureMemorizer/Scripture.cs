using System;
using System.Collections.Generic;

// This class holds the reference and the list of words from the scripture
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Build the scripture and convert the text into Word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the scripture text into individual words
        string[] splitWords = text.Split(" ");

        // Make each word into a Word object
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    // Hides a few random words (may hide words already hidden — core requirement)
    public void HideRandomWord(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count); // pick any word
            _words[index].Hide();                  // hide it
        }
    }

    // Returns the reference and all words (hidden words appear as "_____")
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }

        return result.TrimEnd();
    }

    // Returns true when ALL words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())   // if any word is visible, we're not done
                return false;
        }
        return true;
    }
}
