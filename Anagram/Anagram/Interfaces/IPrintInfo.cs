namespace Anagram.Interfaces
{
    using System.Collections.Generic;

    internal interface IPrintInfo
    {
        void Print(int numberOfAnagramsToFilter, int anagramsToFind, List<string> words, Dictionary<string, List<string>> anagrams);
    }
}
