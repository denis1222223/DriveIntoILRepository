using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIntoILProject
{
    public class QuickSorter
    {
        private Comparer comparer = new Comparer();

        private void QuickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (comparer.Compare(a[i], x) < 0) i++;
                while (comparer.Compare(a[j], x) > 0) j--;
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
                QuickSort(a, i, r);
            if (l < j)
                QuickSort(a, l, j);
        }

        public void Sort(int[] numbers)
        {
            QuickSort(numbers, 0, numbers.Length - 1);
        }
    }

    public class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            else 
            if (x == y)
                return 0;
            else
                return -1;
        }
    }
}
