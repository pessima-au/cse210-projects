using System.Runtime.CompilerServices;

public class RepresentWord
{
    private string _word;

    private bool _IsHidden;


    //constructor to initialize word
    public RepresentWord(string word)
    {
        _word = word;
        _IsHidden = false;
    }
    
    //methods
    public void Hide()
    {
        _IsHidden = true;
    }

    public string GetDisplayText()
    {
        return _IsHidden ? "_" : _word;
    }

    public bool IsHidden()
    {
        return _IsHidden;
    }
}