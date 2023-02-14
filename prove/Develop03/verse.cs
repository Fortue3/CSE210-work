using System;

public class Memorize
{
    private string Scripture;
    ReplaceWord _do = new ReplaceWord();
    
    public void SetWord(string word)
    {
            Scripture = word;
             
        }

    public void GetWord()

    {


        if (Scripture=="John 10:30: I and my father are one")
        {
            _do.Quote1(Scripture);
        }
        
        else if (Scripture == "1Nephi 2:15 : and my father dwelt in a tent")
        {
            _do.Quote2(Scripture);
        }

        else if(Scripture =="John 11:35: and Jesus wept" )
        {
            _do.Quote3(Scripture);
        }
      
    }
}

