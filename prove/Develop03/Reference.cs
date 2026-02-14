using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization.Metadata;
public class Reference
{
    private string book;
    private int chapter;
    private int firstVerse;
    private int lastVerse;
    public Reference(string b,int c,int f)
    {
        book=b;
        chapter=c;
        firstVerse=f;
    }
    public Reference(string b, int c, int f, int l)
    {
        book=b;
        chapter=c;
        firstVerse=f;
        lastVerse=l;
    }
    public string getReferenceString()
    {
        if (lastVerse == 0)
        {
          return $"{book} {chapter}:{firstVerse}";
        }
        else
        {
            return $"{book} {chapter}:{firstVerse}-{lastVerse}";
        }
    }
}