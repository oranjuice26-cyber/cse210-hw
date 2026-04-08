using System;

class ListingActivity : Activity
{
    private List<string> _promptsListListing;
    public ListingActivity(string n, string d, int u) : base(n, d, u)
    {
        
    }
    public void Run()
    {
        
    }
    public void GetListFromUser(List<string> l)
    {
        _promptsListListing=l;
    }
}
    
