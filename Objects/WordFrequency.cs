using System;

namespace Frequency.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _counter = 0;
    string[] stringSeparators = new string[] {" ", "!", "\"", "'", "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "}", "[", "]", ":", ";", "<", ">", ",", ".", "?", "/"};

    public RepeatCounter (string word, string sentence)
    {
      _word = word.ToLower();
      _sentence = sentence.ToLower();
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }
    public int GetCounter()
    {
      return _counter;
    }
    public void SetCounter(int newCounter)
    {
      _counter = newCounter;
    }
    public int CountRepeats()
    {
      string[] words = _sentence.Split(stringSeparators, StringSplitOptions.None);
      for(int i=0; i<words.Length; i++)
      {
        if(words[i] == _word)
        _counter++;
      }
      return _counter;
    }
  }
}
