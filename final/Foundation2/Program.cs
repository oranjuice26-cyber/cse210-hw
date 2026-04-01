using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Normalpants Street", "Rexburg", "Idaho", "USA");
        Address a2 = new Address("1 Fancypants Lane", "London","UK","England");

        Customer bob = new Customer("Bob Robertson",a1);
        Customer rob = new Customer("Robert Robertson III",a2);

        Product Chedder = new Product("Chedder Cheese",1,10,5);
        Product Gouda = new Product("Gouda Cheese",2,9,5);
        Product SpecialGouda = new Product("Dry Aged Gouda Cheese",3,20,5);
        Product SpecialChedder = new Product("Dry Aged Chedder Cheese",4,25,5);

        List<Product> Regular = new List<Product>
        {
            Chedder,Gouda
        };
        List<Product> Special = new List<Product>
        {
            SpecialChedder,SpecialGouda
        };        

        Order RegularOrder = new Order(Regular,bob);
        Order SpecialOrder = new Order(Special,rob);

        Console.Clear();

        Console.WriteLine(RegularOrder.PackingLabel());
        Console.WriteLine(RegularOrder.ShippingLabel());
        Console.WriteLine(RegularOrder.TotalPrice());
        Console.WriteLine();
        Console.WriteLine(SpecialOrder.PackingLabel());
        Console.WriteLine(SpecialOrder.ShippingLabel());
        Console.WriteLine(SpecialOrder.TotalPrice());        

        

    }
}