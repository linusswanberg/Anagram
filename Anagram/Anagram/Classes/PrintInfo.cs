namespace Anagram.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    internal class PrintInfo : IPrintInfo
    {
        public void Print(int numberOfAnagramsToFilter, int anagramWordsToFind, List<string> words, Dictionary<string, List<string>> anagrams)
        {
            var totalAnagramsCount = 0;
            
            foreach (var anagram in anagrams)
            {
                if (anagram.Value.Count < numberOfAnagramsToFilter)
                {
                    continue;
                }

                totalAnagramsCount += anagram.Value.Count;
                Console.Write($"\n Word: {anagram.Key} | Number of anagrams: {anagram.Value.Count} |");
                Console.Write($" Anagrams: ");
                for (var i = 0; i < anagram.Value.Count; i++)
                {
                    Console.Write($"{anagram.Value[i]},");
                    if (i == anagram.Value.Count - 1)
                    {
                        Console.WriteLine($"\n");
                    }
                }
            }

            Console.WriteLine($"\n Total number of words counted: {words.Count}.");
            Console.WriteLine($"\n Total number of anagram words found: {totalAnagramsCount}, the goal was {anagramWordsToFind} based on the description.");
        }
    }
}