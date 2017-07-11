namespace Anagram
{
    using System;
    using System.Diagnostics;
    using Classes;
   
    internal class Program
    {
        private static void Main()
        {
            var totalTime = Stopwatch.StartNew();

            const int numberOfAngramWordsTofilter = 2;
            const int numberOfAnagramWordToFind = 48162;

            var readFile = Stopwatch.StartNew();
            var wordsFromFile = new WordsFromFile();
            var filePath = wordsFromFile.GetFilePath("wordlist.txt");
            var wordsInFile = wordsFromFile.ReadFile(filePath, "ISO-8859-1");
            var splittedWords = wordsFromFile.SplitString(wordsInFile, new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            readFile.Stop();

            var findAllAnagrams = Stopwatch.StartNew();
            var anagrams = new Anagrams();
            var foundAnagrams = anagrams.FindAnagrams(splittedWords);
            findAllAnagrams.Stop();

            var timeToPrint = Stopwatch.StartNew();
            var printInfo = new PrintInfo();
            printInfo.Print(numberOfAngramWordsTofilter, numberOfAnagramWordToFind, splittedWords, foundAnagrams);
            timeToPrint.Stop();
            
            Console.WriteLine($"\n Time to read file from disk and split into words: {readFile.ElapsedMilliseconds}ms.");
            Console.WriteLine($"\n Time to find all anagrams: {findAllAnagrams.ElapsedMilliseconds}ms.");
            Console.WriteLine($"\n Time to print all information: {timeToPrint.ElapsedMilliseconds}ms.");
            Console.WriteLine($"\n Time to run this application: {totalTime.ElapsedMilliseconds}ms.");
            Console.ReadKey();
        }
    }
}