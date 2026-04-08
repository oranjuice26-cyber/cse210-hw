using System;

class ReflectingActivity : Activity
{
    private List<string> _promptsListReflection;
    private List<string> _reflectionQuestionsList;
    public ReflectingActivity(string n, string d, int u, List<String> p, List<string> q) : base(n, d, u)
    {
        _promptsListReflection=p;
        _reflectionQuestionsList=q;
    }
    public void Run()
    {
        
    }
}