using System;

class Program
{
    static void Main(string[] args)
    {
        Comment ac1 = new Comment("Alan","Wow, so true");
        Comment ac2 = new Comment("Alexa","I have been saying this for years");
        Comment ac3 = new Comment("Alex","Thank you for representing us A names");
        List<Comment> cla = new List<Comment>
        {
            ac1,ac2,ac3
        };

        Video a = new Video("Why Names Starting with A are the BEST","Aaron A",120,cla);

        Comment bc1 = new Comment("Billy","Wow, so true");
        Comment bc2 = new Comment("Bobby","I have been saying this for years");
        Comment bc3 = new Comment("Bubba","Thank you for representing us B names");
        List<Comment> clb = new List<Comment>
        {
            bc1,bc2,bc3
        };

        Video b = new Video("Why Names Starting with B are the BEST","Barthelomew B",120,clb);

        Comment cc1 = new Comment("Carl","Wow, so true");
        Comment cc2 = new Comment("Charles","I have been saying this for years");
        Comment cc3 = new Comment("Carla","Thank you for representing us C names");
        List<Comment> clc = new List<Comment>
        {
            cc1,cc2,cc3
        };

        Video c = new Video("Why Names Starting with C are the BEST","Christina C",120,clc);

        Console.Clear();

        a.Display();
        b.Display();
        c.Display();
    }
}