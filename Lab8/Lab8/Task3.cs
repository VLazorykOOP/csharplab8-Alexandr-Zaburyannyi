using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    public class Task3
    {
        static public void Execute()
        {
            string inputPath = @"C:\Lab8\task3\3.txt";    
            string outputPath = @"C:\Lab8\task3\4.txt";  

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Input file not found!");
                return;
            }

            string text = File.ReadAllText(inputPath);

            string pattern = @"\b\w+\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            HashSet<string> uniqueWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            List<string> resultWords = new List<string>();

            foreach (Match match in matches)
            {
                string word = match.Value;
                if (uniqueWords.Add(word))
                {
                    resultWords.Add(word);
                }
            }

            string resultText = string.Join(" ", resultWords);

            File.WriteAllText(outputPath, resultText);

            Console.WriteLine($"Duplicate words have been removed.");
            Console.WriteLine($"Result saved to: {outputPath}");
            Console.WriteLine("Program finished.");
        }
    }
}
