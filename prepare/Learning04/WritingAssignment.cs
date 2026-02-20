using System;

class WritingAssignment : Assignment
{
    private String title;

    public WritingAssignment(string s, string t, string t2) : base(s, t)
    {
        title = t2;
    }
    public string GetWritingInformation()
    {
        string s = GetStudentName();
        return $"{title} By {s}";
    }

}