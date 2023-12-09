namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                using (StreamReader readerText = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string wordsRead = File.ReadAllText(wordsFilePath);
                        string textRead = File.ReadAllText(textFilePath);
                        textRead = Regex.Replace(textRead, "[^a-zA-Z0-9 ]", " ");
                        string[] words = wordsRead
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                        string[] text = textRead
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(text => text.ToLower())
                            .ToArray();

                        Dictionary<string, int> finalList = new Dictionary<string, int>();

                        foreach (string word in words)
                        {
                            int wordsCounter = 0;
                            foreach (string wordsInText in text)
                            {
                                if (word == wordsInText)
                                {
                                    wordsCounter++;
                                }
                            }
                            finalList.Add(word, wordsCounter);
                        }

                        var sorted = finalList.OrderByDescending(x => x.Value);
                        foreach (var item in sorted)
                        {

                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
