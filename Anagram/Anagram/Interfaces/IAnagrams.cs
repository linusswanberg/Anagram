namespace Anagram.Interfaces
{
    using System.Collections.Generic;

    internal interface IAnagrams
    {
        Dictionary<string, List<string>> FindAnagrams(IEnumerable<string> words);
        string SortedWord(string word);
    }
}