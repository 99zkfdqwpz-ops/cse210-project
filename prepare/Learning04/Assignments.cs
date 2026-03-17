public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string GetStudentName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _name + " -> " + _topic;
    }
}