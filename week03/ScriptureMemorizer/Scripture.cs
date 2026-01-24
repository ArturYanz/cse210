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

        string[] pieces = text.Split(" ");
        foreach (string p in pieces)
        {
            _words.Add(new Word(p));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {

            List<Word> visibleWords = new List<Word>();

            foreach (Word word in _words)
            {
                if (word.IsHidden() == false)
                {
                    visibleWords.Add(word);
                }
            }
            if (visibleWords.Count == 0)
            {
                break;
            }

            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();


        }
    
    }
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    
    
    }


}