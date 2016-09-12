using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIntoILProject
{
    class Program
    {
        static void GuickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                GuickSort(a, i, r);

            if (l < j)
                GuickSort(a, l, j);
        }

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

            int[] numbers = GenerateRandomNumbers(10);

            GuickSort(numbers, 0, 9);
            for (int i = 0; i < 9; i++)
            {
                Console.Write(numbers[i].ToString());
                Console.Write(" ");
            }
            Console.ReadKey();
            return 0;
        }
    }
}
