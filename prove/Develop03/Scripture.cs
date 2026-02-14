using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private List<Word> Text = new List<Word>{};
    private Reference reference;
    public Scripture(Reference r, string t)
    {
        reference=r;
        foreach(string w in t.Split(" "))
        {
            Word a = new Word(w);
            Text.Add(a);
        }
    }
    public void Display()
    {
        string s ="";
        foreach(Word w in Text)
        {
            s=s+w.showWord()+" ";
        }
        Console.WriteLine($"{reference.getReferenceString()} {s}");
    }
    public List<Word> getText()
    {
        return Text;
    }
}