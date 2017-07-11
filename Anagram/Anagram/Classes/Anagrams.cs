namespace Anagram.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    internal class Anagrams : IAnagrams
    {
        public Dictionary<string, List<string>> FindAnagrams(IEnumerable<string> words)
        {
            var anagrams = new Dictionary<string, List<string>>();

            foreach (var word in words)
            {
                var sortedWord = this.SortedWord(word);

                if (anagrams.ContainsKey(sortedWord))
                {
                    anagrams[sortedWord].Add(word);
                }
                else
                {
                    anagrams.Add(sortedWord, new List<string>());
                    anagrams[sortedWord].Add(word);
                }
            }
            return anagrams;
        }

        public string SortedWord(string word)
        {
            var wordAsChars = word.ToCharArray();
            Array.Sort(wordAsChars);
            return new string(wordAsChars);
        }
    }
}