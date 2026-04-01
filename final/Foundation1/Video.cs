using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public int NumOfComments()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author}. Length: {_length} seconds. Number of Comments: {NumOfComments()}");
        for(int i = 0; i < NumOfComments(); i++)
        {
            _comments[i].Display();
        }
    }
    public Video(string t, string a, int l, List<Comment> c)
    {
        _title=t;
        _author=a;
        _length=l;
        _comments=c;
    }
}
