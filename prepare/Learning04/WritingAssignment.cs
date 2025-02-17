public class writingAssignment : Assignment
{
    private string _title;

    public writingAssignment(string studentName, string topic, string tilte)
        : base(studentName, topic)
    {
        _title = tilte;
    }

    public string GetWritingInformation()
    {
        string studentName = GetstudentName();
        string writingInformation = $"{_title} by {studentName}";
        return writingInformation;
    }
}