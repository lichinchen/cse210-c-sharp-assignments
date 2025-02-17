public class Assignment
{
    private string _studentName;
    private string _topic;
     
    public Assignment(string studnetName, string topic)
    {
        _studentName = studnetName;
        _topic = topic;
    }

    public string GetstudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}