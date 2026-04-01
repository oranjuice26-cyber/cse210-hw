using System;

class Customer
{
    private string _name;
    private Address _address;
    public Customer(string n, Address a)
    {
        _name=n;
        _address=a;
    }
    public bool InUSA()
    {
        return _address.InUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
}