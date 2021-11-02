﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class PigLatin
    {
        public bool IsVowel(char w)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


            foreach (char c in vowels)
            {
                if (c == w)
                {
                    Console.WriteLine(vowels[0]);
                }
            }
            return true;

        }

        //public string SpecialCharacters(string word)
        //{
        //    char[] specialChars = { '@', '.', '-', '$', '^', '&' };
        //    word = word.ToLower();
        //    foreach (char c in specialChars)
        //    {
        //        foreach (char w in word)
        //        {
        //            if (w == c)
        //            {
        //                Console.WriteLine("That word has special characters, we will return it as is");
        //                return word;
        //            }
        //        }

        //    }
        //    return "test";
        //}

        public string ToPigLatin(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }

            }

            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word;
            }

            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                //output = word + "ay";
                output = word + "way"; 
            }
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                string sub = word.Substring(0, 1);
                string postFix = word.Substring(1);

                output = sub + postFix + "ay";
            }

            return output;


        }   }
}


//        public string ToPigLatin(string word)
//        {
//            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
//            word = word.ToLower();
//            foreach (char c in specialChars)
//            {
//                foreach (char w in word)
//                {
//                    if (w == c)
//                    {
//                        Console.WriteLine("That word has special characters, we will return it as is");
//                        return word;
//                    }
//                }

//            }

//            bool noVowels = true;
//            foreach (char letter in word)
//            {
//                if (IsVowel(letter))
//                {
//                    noVowels = false;
//                }
//            }

//            if (noVowels)
//            {
//                return word;
//            }

//            char firstLetter = word[0];
//            string output = "placeholder";
//            if (IsVowel(firstLetter) == true)
//            {
//                output = word + "ay";
//            }
//            else
//            {
//                int vowelIndex = -1;
//                //Handle going through all the consonants
//                for (int i = 0; i <= word.Length; i++)
//                {
//                    if (IsVowel(word[i]) == true)
//                    {
//                        vowelIndex = i;
//                        break;
//                    }
//                }

//                string sub = word.Substring(vowelIndex + 1);
//                string postFix = word.Substring(0, vowelIndex - 1);

//                output = sub + postFix + "ay";
//            }

//            return output;
//        }
//    }
//}






