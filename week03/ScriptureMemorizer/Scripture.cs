

public class Scripture
{
  //attribute
  private Reference _reference;
  private List<Word> _word;

  //constructors
  public Scripture(Reference reference, string text)
  {
    this._reference = reference;
    this._word = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string w in words)
        {
            _word.Add(new Word(w));
        }
  }

  //methods
  public void HideRandomWords(int numberToHide)
  {
        Random rand = new Random();
        int hiddenCount = 0;

        // Get only words that are not hidden yet
        List<Word> visibleWords = _word.Where(w => !w.IsHidden()).ToList();

        while (hiddenCount < numberToHide && visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hiddenCount++;
        }
   }
  public string GetDisplayText()
  { 
     string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _word)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
   }
  public bool isCompletelyHidden()
  {
        return _word.All(Word => Word.IsHidden());
   }
}