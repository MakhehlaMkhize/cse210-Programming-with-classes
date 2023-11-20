using System;
using System.Data.Common;
public class Scripture
{   
    private Reference _reference;
    private List<Word> _scriptureWords = new();
    public Scripture(Reference scriptRef, string text)
    {
        _reference = scriptRef;
        
        string [] scriptWords = text.Split(" ");
        
        foreach (string scriptWord in scriptWords)
        {
            Word word = new(scriptWord);
            _scriptureWords.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {   
        Random random = new();
        for (int i = 0; i < numberToHide; i++)
        {   
            int randomIndex;
            bool hidden = true;
            do
            {
                randomIndex = random.Next(_scriptureWords.Count);
                if (_scriptureWords[randomIndex].IsHidden() == true)
                {
                    hidden = true;
                }
                else
                {
                    _scriptureWords[randomIndex].Hide();
                    hidden = false;
                }
            }
            while (hidden);
            
        }
    }
    public string GetDisplayScripture()
    {
        string displayPhrase = "";
        foreach ( Word word in _scriptureWords)
        {
            displayPhrase += word.GetDisplayWord() +" ";
        }
        return $"{_reference.GetDisplayReference()} {displayPhrase}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _scriptureWords)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}