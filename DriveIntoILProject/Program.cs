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
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
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
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 7, 4, 2, 9 };
            GuickSort(a, 0, 4);
            for (int i = 0; i<5; i++)
            {
                Console.Write(a[i].ToString(), " ");
            }
            Console.ReadKey();
        }
    }
}
