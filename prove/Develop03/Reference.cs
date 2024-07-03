using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructor
    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string Getbook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse != -1)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return $"{_book} {_chapter}:{_verse}";
    }

    public void SetDisplayText(string Display)
    {
        var parts = Display.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 3)
        {
            _book = parts[0];
            _chapter = int.Parse(parts[1]);
            _verse = int.Parse(parts[2]);
        }
        else if (parts.Length == 4)
        {
            _book = parts[0];
            _chapter = int.Parse(parts[1]);
            _verse = int.Parse(parts[2]);
            _endVerse = int.Parse(parts[3]);

        }
        else{
            throw new FormatException("Invalid display text format. Expected format: 'Book Cjhapter:Verse'");
        }
    } 

}