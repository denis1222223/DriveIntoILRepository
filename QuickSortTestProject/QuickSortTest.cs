using DriveIntoILProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSortTestProject
{
    [TestClass]
    public class QuickSortTest
    {
        private QuickSorter sorter = new QuickSorter();

        [TestMethod]
        public void QuickSortMainTest()
        {
            int[] unsorted = { 1, 5, 3, 7, 6 };
            int[] sorted = { 1, 3, 5, 6, 7 };

            sorter.Sort(unsorted);
            CollectionAssert.AreEqual(sorted, unsorted);
        }

        [TestMethod]
        public void QuicksortMethodWithZeroTest()
        {
            int[] unsorted = { 0 };
            int[] sorted = { 0 };

            sorter.Sort(unsorted);
            CollectionAssert.AreEqual(sorted, unsorted);
        }

        [TestMethod]
        public void QuicksortMethodWithSameElementsTest()
        {
            int[] unsorted = { 6, 6, 6, 6, 6 };
            int[] sorted = { 6, 6, 6, 6, 6 };

            sorter.Sort(unsorted);
            CollectionAssert.AreEqual(sorted, unsorted);
        }
    }


}
