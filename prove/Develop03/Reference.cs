public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    //constructor for single verse
    public Reference(string book,int chapter,int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse =verse;
        _endverse = 0;
    }

    // constructor for verse range
    public Reference (String book,int chapter,int verse,int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endVerse;

    }

    public string GetDisplayText()
    {
        if (_endverse == 0)
        {
            return $"{_book}{_chapter}:{_verse}";
        }
        else
        {
            return $"{_book}{_chapter}:{_verse}-{_endverse}";
        }
    }
}