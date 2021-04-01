using System;
using System.IO;

namespace Advent_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSeatID = 0;
            string[] lines = File.ReadAllLines(@"C:\Users\User\Desktop\SPARTA\TRAINING\Advent_of_Code_2020\Advent_Day5\input.txt");
            foreach (var line in lines)
            {
                var replacementF = line.Replace("F", "0");
                var replacementB = replacementF.Replace("B", "1");
                var replacementL = replacementB.Replace("L", "0");
                var replacementR = replacementL.Replace("R", "1");
                string rowString = replacementB.Substring(0, 7);
                string seatString = replacementR.Substring(7, 3);
                int row = Convert.ToInt32(rowString, 2);
                int seat = Convert.ToInt32(seatString, 2);
                int seatID = (row * 8) + seat;

                //Console.WriteLine(replacementB);
                //Console.WriteLine(rowString);
                //Console.WriteLine(seatString);
                //Console.WriteLine(row);
                //Console.WriteLine(seat);
                //Console.WriteLine(seatID);

                if (seatID>maxSeatID)
                {
                    maxSeatID = seatID;
                }
            }
            Console.WriteLine(maxSeatID);
        }
    }
}
