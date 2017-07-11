namespace Anagram.Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Interfaces;

    internal class WordsFromFile : IWordsFromFile
    {
        public string GetFilePath(string fileName)
        {
            var path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

            if (path == null)
            {
                return string.Empty;
            }

            path = Directory.GetParent(Directory.GetParent(path).FullName).FullName + '\\' + fileName;

            return path;
        }

        public string ReadFile(string path, string encoding)
        {
            var textInFile = File.ReadAllText(path, Encoding.GetEncoding(encoding));

            return textInFile;
        }

        public List<string> SplitString(string word, char[] separator, StringSplitOptions option)
        {
            var splittedString = word.Split(separator, option).ToList();

            return splittedString;
        }
    }
}
