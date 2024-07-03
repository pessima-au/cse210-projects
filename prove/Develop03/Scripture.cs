using System.ComponentModel;

public class Scripture
{
    //class attributes
    private  Reference _reference;
    private List<RepresentWord> _words;

    //constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new char[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => new RepresentWord(word))
                    .ToList();
    }

    //methods
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{referenceText}: {wordsText}";
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsCount = _words.Count;
    
        if (numberToHide > wordsCount)
        {
            numberToHide = wordsCount;
        }

        List<int> hiddenIndices = new List<int>();
        while (hiddenIndices.Count < numberToHide)
        {
            int index  = rand.Next(wordsCount);
            if (!hiddenIndices.Contains(index))
            {
                _words[index].Hide();
                hiddenIndices.Add(index);
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }


}