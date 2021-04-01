using System;
using System.IO;

namespace Advent_Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readFile = new StreamReader(@"C:\Users\User\Desktop\SPARTA\TRAINING\Advent_of_Code_2020\Advent_Day6\input.txt");
            string Data = readFile.ReadToEnd();
            string[] groups = Data.Split( "\n\n");
            int total = 0;

            foreach (var group in groups)
            {
                Console.WriteLine(group);
                string oneLine = group.Replace("\n", "");
                Console.WriteLine(oneLine);
                string removaldup = "";
                foreach (char c in oneLine)
                {
                    if (!removaldup.Contains(c))
                    {
                        removaldup += c;
                    }
                }
                Console.WriteLine(removaldup);
                Console.WriteLine(removaldup.Length);
                total += removaldup.Length;
            }
            Console.WriteLine(total);
        }
    }
}
