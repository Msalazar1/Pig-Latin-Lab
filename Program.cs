using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace igPay_atinLay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pig Latin for Dummies!");
            Console.WriteLine("*********************************");
            Console.WriteLine("Type any word or sentence and we will translate it for you: ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("");
            string sentence = Console.ReadLine();
            string pigLatin = PigLatinTrans(sentence);  // calls the function
            Console.WriteLine(pigLatin);  // prints 

        }
        static string PigLatinTrans (string sentence)  // function
        {
            string vowels = "AEIOUaeiou"; // Identifying vowels
            List<string> pigWord = new List<string>();  // Creates a list to hold our words
            foreach (string word in sentence.Split ())  // Separates the string  
            {
                string firstLetter = word.Substring(0, 1);  //Separates the first character from the word                
                string restOfWord = word[1..];  //VS recommended this change from (1, word.Length - 1). Remainder of word minus first letter
                int currentLetter = vowels.IndexOf (firstLetter);  //Index of identified vowels

            if (currentLetter == - 1)  //Check if first letter is a vowel
                {
                    pigWord.Add(restOfWord + firstLetter + "ay");  //first letter is not a vowel
                }
            else
                {
                    pigWord.Add(word + "way");  // First letter is a vowel
                }
            }
            return string.Join(" ", pigWord);  // Joins the string back together with a space between words
         
            
        }
    }
}
