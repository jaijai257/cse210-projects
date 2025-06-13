using System;
public class Word{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
    public void Hide()
    {
        IsHidden = true;
    }
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }


}
