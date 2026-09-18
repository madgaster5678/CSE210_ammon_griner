using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> availableWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                availableWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && availableWords.Count > 0; i++)
        {
            int availableIndex = random.Next(availableWords.Count);
            availableWords[availableIndex].Hide();
            availableWords.Remove(availableWords[availableIndex]);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}