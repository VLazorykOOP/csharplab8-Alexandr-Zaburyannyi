using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    public class Task2
    {
        static public void Execute()
        {
            string inputPath = @"C:\Lab8\task2\1.txt";    
            string outputPath = @"C:\Lab8\task2\2.txt";

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Input file not found!");
                return;
            }

            string text = File.ReadAllText(inputPath);

            string pattern = @"\b[A-Za-z]+\b";

            string replacedText = Regex.Replace(text, pattern, "...");

            File.WriteAllText(outputPath, replacedText);

            Console.WriteLine($"English words have been replaced with '...'.");
            Console.WriteLine($"Result saved to: {outputPath}");
            Console.WriteLine("Program finished.");
        }
    }
}
