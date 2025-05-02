using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;


namespace Lab8
{
    public class Task1
    {
        static public  void Execute() {
            string inputPath = @"C:\Lab8\task1\input.txt";
            string outputPath = @"C:\Lab8\task1\output.txt";

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Input file not found!");
                return;
            }

            List<string> foundSites = new List<string>();
            string pattern = @"\b(?:\w+\.)*cv\.ua\b";

            foreach (var line in File.ReadLines(inputPath))
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match match in matches)
                {
                    foundSites.Add(match.Value);
                }
            }

            Console.WriteLine("Found addresses:");
            foreach (string site in foundSites)
            {
                Console.WriteLine(site);
            }

            File.WriteAllLines(outputPath, foundSites);

            Console.WriteLine($"\nTotal addresses found: {foundSites.Count}");
            Console.WriteLine($"Addresses have been saved to: {outputPath}");
            Console.WriteLine("Program finished.");
        }
    }
}
