using System;
using System.IO;
using System.Linq;

namespace Advent_Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readFile = new StreamReader(@"C:\Users\User\Desktop\SPARTA\TRAINING\Advent_of_Code_2020\Advent_Day6\input.txt");
            string Data = readFile.ReadToEnd();
            string[] groups = Data.Split( "\n\n");

            /* PART 1
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
            */

            int totalB = 0;
            foreach (var group in groups)
            {
                string[] lines = group.Split("\n");
                string anyYesAnswers = "";
                for (int i = 0; i < lines.Length; i++)
                {
                    foreach (char c in lines[i])
                    {
                        if (lines[0].Contains(c))
                        {
                            anyYesAnswers += c;
                        }
                    }

                }
                //Console.WriteLine(allForThisGroup);
                
                string allYes = "";
                foreach (char letter in anyYesAnswers)
                {
                    int freq = anyYesAnswers.Count(f => (f == letter));
                    if (freq==lines.Length && !allYes.Contains(letter))
                    {
                        allYes += letter;
                    }
                }
                Console.WriteLine(allYes);
                Console.WriteLine(allYes.Length);
                totalB += allYes.Length;
            }
            Console.WriteLine(totalB);
        }
    }
}
