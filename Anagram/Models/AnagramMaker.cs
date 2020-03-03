using System;
using System.Collections.Generic;
using System.Linq;



namespace Anagram.Models
{
    public class AnagramSwitcher
    {

        public string IsAnagram(string input)
        {
             
            string word2 = "bread";

            char [] char1 = input.ToLower().ToCharArray();
            char [] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);


            
            if(char1.SequenceEqual(char2))
            {
            return "yes";
            }
            else
            {
            return "false";
            }
        }
    }
}