using System;
using System.Collections.Generic;
using System.IO;

namespace Advent_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> seatAll = new List<int>();

            // PART 1 int maxSeatID = 0;
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

                seatAll.Add(seatID);

                //Console.WriteLine(replacementB);
                //Console.WriteLine(rowString);
                //Console.WriteLine(seatString);
                //Console.WriteLine(row);
                //Console.WriteLine(seat);
                //Console.WriteLine(seatID);

                /* PART 1
                if (seatID>maxSeatID)
                {
                    maxSeatID = seatID;
                }
                */
            }
            // PART 1 Console.WriteLine(maxSeatID);

            //PART 2
            seatAll.Sort();
            for (int i = 100; i < 862; i++)
            {
                if (seatAll.Contains(i))
                {

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
