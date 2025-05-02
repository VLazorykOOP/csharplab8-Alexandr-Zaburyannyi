using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Task4
    {

        static public void Execute()
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40 };
            int k = 10;
            string filePath = @"C:\Lab8\task4\5.bin";

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                foreach (int number in numbers)
                {
                    if (number % k != 0)
                    {
                        writer.Write(number);
                    }
                }
            }

            Console.WriteLine("Numbers not divisible by " + k + " have been written to the binary file.");

            Console.WriteLine("Numbers in the binary file:");
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine("\nProgram finished.");
        }
    }
}
