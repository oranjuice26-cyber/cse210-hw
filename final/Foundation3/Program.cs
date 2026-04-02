using System;

class Program
{
    static void Main(string[] args)
    {
        Address a = new Address("1 Fancypants Lane", "London","UK","England");
        DateOnly d = new DateOnly(2026,4,10);
        TimeOnly t = new TimeOnly(8, 30);
        Lecture l = new Lecture("Lulu's Secrets to Success","A guide on how to replicate the famous Lulu Lemon and accquire a family fortune!", d,t,a,"Lulu Lemon",1000);

        Address a2 = new Address("123 Church Street", "London","UK","England");
        DateOnly d2 = new DateOnly(2026,7,3);
        TimeOnly t2 = new TimeOnly(16, 30);
        Reception r = new Reception("Aaron and Bridget's Wedding Reception","The reception for the marriage of Aaron Barney Jackson and Bridget Lucy Johnson", d2,t2,a2,"abjackson23@gmail.com");

        Address a3 = new Address("760 Memorial Lane", "West Des Moines","IA","USA");
        DateOnly d3 = new DateOnly(2026,5,25);
        TimeOnly t3 = new TimeOnly(7, 30);
        Outdoor o = new Outdoor("Racoon River Ward Memorial Day Breakfast","A breakfast to remember our veterens and enjoy each others company", d3,t3,a3,"60 degrees and sunny");

        Console.Clear();
        l.ShortDescription();
        l.StandardDetails();
        l.FullDetails();
        Console.WriteLine("__________________________");
        r.ShortDescription();
        r.StandardDetails();
        r.FullDetails();
        Console.WriteLine("__________________________");
        o.ShortDescription();
        o.StandardDetails();
        o.FullDetails();
    }
}