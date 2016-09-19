using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIntoILProject
{
    class Program
    {
        private static int ParseArguments(string[] args)
        {
            int length = 0;
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a numeric argument.");
                return 0;
            }
            if (!Int32.TryParse(args[0], out length))
            {
                Console.WriteLine("You must enter numeric value as argument.");
                return 0;
            }
            return length;
        }

        private static int[] GenerateRandomNumbers(int length, int min = -9, int max = 9)
        {
            int[] numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(min, max);
            }
            return numbers;
        }

        static int Main(string[] args)
        {
            //int length = ParseArguments(args);
            //if (length == 0)
            //    return 1;

            int[] numbers = GenerateRandomNumbers(5);

            QuickSorter sorter = new QuickSorter();
            sorter.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i].ToString());
                Console.Write(" ");
            }
            Console.ReadKey();
            return 0;
        }
    }
}
