public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;
    public MathAssignment(string Name, string topic, string Section, string problems)
        : base(Name, topic)
    {
        _section = Section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}