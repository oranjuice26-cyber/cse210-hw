using System;

class Word
{
    private string W;
    private Boolean isHidden;

    public Word(string w)
    {
        W=w;
        isHidden=false;
    }
    public void hideWord()
    {
        isHidden=true;
    }
    public string showWord()
    {
        if (isHidden == true)
        {
            string newWord = "";
            foreach(char c in W)
            {
                newWord=newWord+"_";
            }
            return newWord;
        }
        else
        {
            return W;
        }
    }
    public bool getIsHidden()
    {
        return isHidden;
    }
}