public class MathAssignment : Assignment
{
    // Ensure the base class 'Assignment' is defined and accessible
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}, Problems {_problems}";
    }

}