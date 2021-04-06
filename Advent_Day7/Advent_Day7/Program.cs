using System;
using System.IO;

namespace Advent_Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readFile = new StreamReader(@"C:\Users\User\Desktop\SPARTA\TRAINING\Advent_of_Code_2020\Advent_Day7\input.txt");
            string Data = readFile.ReadToEnd();
            string[] groups = Data.Split("\n");

            Console.WriteLine(groups[0]);
        }
    }
}
