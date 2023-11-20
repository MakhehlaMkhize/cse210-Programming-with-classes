using System;
using System.Runtime.CompilerServices;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayWord()
    {
        
        if (_isHidden == true)
        {
            List<string> hideWord = new();
            foreach ( char c in _word)
            {
                hideWord.Add("_");
            }
            string hiddenWord = string.Join("", hideWord);
            return _word = hiddenWord;
        }
        else
        {
            return _word;
        }
    }
    
    
}