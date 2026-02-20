using System;

class MathAssignment : Assignment
{
    private String textbookSection;
    private string problems;
    public MathAssignment(string s, string t, string b, string p) : base(s, t)
    {
        textbookSection = b;
        problems = p;
    }
    public string GetHomeworkList()
    {
        return $"Chapter {textbookSection} Problems {problems}";
    }
}