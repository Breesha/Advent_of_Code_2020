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
                string allForThisGroup = "";
                for (int i = 1; i < lines.Length; i++)
                {

                    foreach (char c in lines[i])
                    {
                        if (lines[0].Contains(c) && !allForThisGroup.Contains(c))
                        {
                            allForThisGroup += c;
                        }
                        else if (allForThisGroup.Contains(c) && !lines[0].Contains(c))
                        {
                            allForThisGroup.Remove(allForThisGroup.IndexOf(c),0);
                        }
                    }
                    
                }
                Console.WriteLine(allForThisGroup);
                    Console.WriteLine(allForThisGroup.Length);
                    totalB += allForThisGroup.Length;
            }
            Console.WriteLine(totalB);
        }
    }
}
