﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summerizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sentence = "This is going to be a really really" +
                "really really really long text.";
            var summary = SummrizeText(sentence,25);
            Console.WriteLine(summary);
            
        }

        static string SummrizeText(string text, int maxLength =20)
        {
           
            if (text.Length < maxLength)
                return text;
                
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return String.Join(" ", summaryWords) + "...";

        }
    }
}
