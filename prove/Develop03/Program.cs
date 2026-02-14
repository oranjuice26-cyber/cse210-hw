using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("2nd Nephi",4,19,22);
        Scripture s = new Scripture(r,"And when I desire to rejoice, my heart groaneth because of my sins; nevertheless, I know in whom I have trusted. My God hath been my support; he hath led me through mine afflictions in the wilderness; and he hath preserved me upon the waters of the great deep. He hath filled me with his love, even unto the consuming of my flesh. He hath confounded mine enemies, unto the causing of them to quake before me.");
        bool allHidden=false;
        Random ra = new Random();
        while (true)
        {
            
            Console.Clear();
            s.Display();
            Console.Write("Hit enter to remove words or type quit to end the program:");
            int n = 4;
            foreach(Word w in s.getText())
            {
                if (w.getIsHidden() == true)
                {
                    allHidden=true;
                }
                else
                {
                    allHidden=false;
                    break;
                }
            }
            if (Console.ReadLine() == "quit" || allHidden == true)
            {
                break;
            }
            for(int i=0; i < s.getText().Count; i++)
            {
                if (n > 0)
                {
                    Word w= s.getText()[i];
                    if (w.getIsHidden()==false && ra.Next(0,2)==1)
                    {
                        w.hideWord();
                        n--;
                    }

                }
            }
        }
    }
}
