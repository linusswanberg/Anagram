namespace Anagram.Interfaces
{
    using System;
    using System.Collections.Generic;

    internal interface IWordsFromFile
    {
        string GetFilePath(string fileName);
        string ReadFile(string path, string encoding);
        List<string> SplitString(string word, char[] separator, StringSplitOptions option);
    }
}