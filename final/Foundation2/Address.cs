using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public bool InUSA()
    {
        return (_country=="USA");
    }
    public string FullAddress()
    {
        return ($"{_streetAddress}\n{_city} {_state}\n{_country}");
    }
    public Address(string s, string i, string t, string o)
    {
        _streetAddress=s;
        _city=i;
        _state=t;
        _country=o;
    }
}