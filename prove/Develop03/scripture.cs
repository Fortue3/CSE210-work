using System;

public class Scriptures
{
    private string _quote;

    public string SetScripture()
        
        {
        Random randomGenerator = new Random();
        string[] Scriptures = {"Proverb 3:5-6: Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", "John 10:30: I and my father are one","John 11:35: and Jesus wept", "1Nephi 2:15 : and my father dwelt in a tent"};
        int index = randomGenerator.Next(Scriptures.Length);
        _quote = (Scriptures[index]);
        return _quote;
        
        }
        public string GetScripture()
        {

            return  _quote;
        }
    }