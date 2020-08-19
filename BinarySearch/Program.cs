using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            string input;
            int searchNum;
            int minNum = 0;
            int maxNum = list.Count - 1;
            bool found = false;
            int midNum = 0;

            Console.Write("Enter a number between 1 and 13 to search: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out searchNum);

            while (!found)
            {
                midNum = (minNum + maxNum) / 2;
                if (searchNum == list[midNum])
                {
                    found = true;
                }
                else if (minNum == maxNum)
                {
                    midNum = -1;
                    found = true;
                }
                else if (searchNum < midNum)
                {
                    maxNum = midNum - 1;
                }
                else
                {
                    minNum = midNum + 1;
                }
            }

            Console.WriteLine(midNum);

        }
    }
}
