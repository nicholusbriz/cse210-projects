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
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hidden = 0;
        List<int> available = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                available.Add(i);
        }
        while (hidden < numberToHide && available.Count > 0)
        {
            int idx = rand.Next(available.Count);
            _words[available[idx]].Hide();
            available.RemoveAt(idx);
            hidden++;
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word w in _words)
        {
            displayWords.Add(w.GetDisplayText());
        }
        return _reference.GetDisplayText() + " " + string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}
