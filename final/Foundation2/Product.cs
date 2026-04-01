using System;

class Product
{
    private string _name;
    private int _id;
    private int _pricePerUnit;
    private int _quantity;

    public int TotalPrice()
    {
        return (_pricePerUnit*_quantity);
    }
    public string PackingLabel()
    {
        return $"{_name} Product ID:{_id}";
    }
    public Product(string n, int i, int p, int q)
    {
        _name=n;
        _id=i;
        _pricePerUnit=p;
        _quantity=q;
    }
}