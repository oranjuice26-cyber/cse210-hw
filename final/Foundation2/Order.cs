using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    public int TotalPrice()
    {
        int t=0;
        foreach(Product p in _products)
        {
            t=t+p.TotalPrice();
        }
        if (_customer.InUSA())
        {
            t=t+5;
        }
        else
        {
            t=t+35;
        }
        return t;
    }
    public string PackingLabel()
    {
        string l = "";
        foreach(Product p in _products)
        {
            l=l+p.PackingLabel()+"\n";
        }
        return l;
    }
    public string ShippingLabel()
    {
        return ($"{_customer.GetName()}\n{_customer.GetAddress().FullAddress()}");
    }
    public Order(List<Product> p, Customer c)
    {
        _products=p;
        _customer=c;
    }
}