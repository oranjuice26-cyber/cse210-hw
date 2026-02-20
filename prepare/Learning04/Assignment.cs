using System;

class Assignment
{
    private string studentName;
    private string topic;
    public Assignment(string s, string t)
    {
        studentName=s;
        topic=t;
    }
    public string GetSummary()
    {
        return $"{studentName} - {topic}";
    }
    public string GetStudentName()
    {
        return studentName;
    }
}